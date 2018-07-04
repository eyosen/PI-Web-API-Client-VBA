// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using PIWebAPIWrapper.Api;
using PIWebAPIWrapper.Client;
using PIWebAPIWrapper.WebID;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace PIWebAPIWrapper
{
    [ComVisible(true)]
    [Guid("2BF7DA6B-DDB3-42A5-BD65-92EE93ABB473")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IPIWebApiClient
    {
		/// <summary>Try to connect to PI Web API</summary>
        [DispId(1)]
        bool Connect(string baseUrl, bool useKerberos, string username = null, string password = null);
        [DispId(2)]
        IAnalysisApi Analysis { get; }
        [DispId(3)]
        IAnalysisCategoryApi AnalysisCategory { get; }
        [DispId(4)]
        IAnalysisRulePlugInApi AnalysisRulePlugIn { get; }
        [DispId(5)]
        IAnalysisRuleApi AnalysisRule { get; }
        [DispId(6)]
        IAnalysisTemplateApi AnalysisTemplate { get; }
        [DispId(7)]
        IAssetDatabaseApi AssetDatabase { get; }
        [DispId(8)]
        IAssetServerApi AssetServer { get; }
        [DispId(9)]
        IAttributeApi Attribute { get; }
        [DispId(10)]
        IAttributeCategoryApi AttributeCategory { get; }
        [DispId(11)]
        IAttributeTraitApi AttributeTrait{ get; }
        [DispId(12)]
        ICalculationApi Calculation { get; }
        [DispId(13)]
        IDataServerApi DataServer { get; }
        [DispId(14)]
        IElementApi Element { get; }
        [DispId(15)]
        IElementCategoryApi ElementCategory { get; }
        [DispId(16)]
        IElementTemplateApi ElementTemplate { get; }
        [DispId(17)]
        IEnumerationSetApi EnumerationSet { get; }
        [DispId(18)]
        IEnumerationValueApi EnumerationValue { get; }
        [DispId(19)]
        IEventFrameApi EventFrame { get; }
        [DispId(20)]
        IHomeApi Home { get; }
        [DispId(21)]
        INotificationContactTemplateApi NotificationContactTemplate { get; }
        [DispId(22)]
        INotificationRuleApi NotificationRule { get; }
        [DispId(23)]
        INotificationRuleSubscriberApi NotificationRuleSubscriber { get; }
        [DispId(24)]
        INotificationRuleTemplateApi NotificationRuleTemplate { get; }
        [DispId(25)]
        IPointApi Point { get; }
        [DispId(26)]
        ISecurityIdentityApi SecurityIdentity { get; }
        [DispId(27)]
        ISecurityMappingApi SecurityMapping { get; }
        [DispId(28)]
        IStreamApi Stream { get; }
        [DispId(29)]
        IStreamSetApi StreamSet { get; }
        [DispId(30)]
        ISystemApi System { get; }
        [DispId(31)]
        ITableApi Table { get; }
        [DispId(32)]
        ITableCategoryApi TableCategory { get; }
        [DispId(33)]
        ITimeRuleApi TimeRule { get; }
        [DispId(34)]
        ITimeRulePlugInApi TimeRulePlugIn { get; }
        [DispId(35)]
        IUnitApi Unit { get; }
        [DispId(36)]
        IUnitClassApi UnitClass { get; }
        [DispId(37)]
        WebIdHelper WebIdHelper { get; }

        /// <summary>Get defined user name</summary>
        [DispId(38)]
        string UserName { get; }
		
		/// <summary>Get defined PI Web API base service url</summary>
        [DispId(39)]
        string BaseUrl { get; }
		
		/// <summary>Check if the authentication which is being used is Kerberos or Basic</summary>
        [DispId(40)]
        bool UseKerberos { get; }

    }

    [ComVisible(true)]
    [Guid("56C41646-10CB-4188-979D-23F70E0FFDF5")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(IPIWebApiClient))]
    [ProgId("PIWebAPIWrapper.PIWebApiClient")]

    public class PIWebApiClient : IPIWebApiClient
    {
        private ApiClient client = null;
        private string baseUrl;
        private bool useKerberos;
        private string userName;
        private string password;
        private bool cacheDisabled = false;

        public PIWebApiClient()
        {

        }

		/// <summary>Try to connect to PI Web API</summary>
        public bool Connect(string baseUrl, bool useKerberos, string username = null, string password = null)
        {
            try
            {
                this.baseUrl = baseUrl;
                this.useKerberos = useKerberos;
                this.userName = username;
                this.password = password;
                cacheDisabled = true;
                client = new ApiClient(baseUrl);
                var links = Home.Get();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

		/// <summary>Get defined user name</summary>
        public string UserName 
		{ 
			get
			{
				return userName;
			}
		}
		
		/// <summary>Get defined PI Web API base service url</summary>
		public string BaseUrl 
		{ 
			get
			{
				return baseUrl;
			}
		}
		
		/// <summary>Check if the authentication which is being used is Kerberos or Basic</summary>
		public bool UseKerberos
		{ 
			get
			{
				return useKerberos;
			}
		}		


        private Configuration GetConfiguration(bool NoCacheHeaderCompatible)
        {
            Configuration config = null;
            if ((useKerberos == false) && (userName != null) && (password != null))
            {
                config = new Configuration(client, null, userName, password);
       
            }
            else
            {
                config = new Configuration(client);
                client.RestClient.Authenticator = new DefaultAuthenticator();
            }

            if ((NoCacheHeaderCompatible == true) && (cacheDisabled == true))
            {
                config.DefaultHeader.Add("Cache-Control", "no-cache");
            }
            return config;
        }


        public class DefaultAuthenticator : IAuthenticator
        {
            public void Authenticate(IRestClient client, IRestRequest request)
            {
                request.UseDefaultCredentials = true;
            }
        }

        public IAnalysisApi Analysis
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisApi(config);
            }
        }

        public IAnalysisCategoryApi AnalysisCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisCategoryApi(config);
            }
        }

        public IAnalysisRulePlugInApi AnalysisRulePlugIn
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisRulePlugInApi(config);
            }
        }

        public IAnalysisRuleApi AnalysisRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisRuleApi(config);
            }
        }

        public IAnalysisTemplateApi AnalysisTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisTemplateApi(config);
            }
        }

        public IAssetDatabaseApi AssetDatabase
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AssetDatabaseApi(config);
            }
        }

        public IAssetServerApi AssetServer
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AssetServerApi(config);
            }
        }

        public IAttributeApi Attribute
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeApi(config);
            }
        }

        public IAttributeCategoryApi AttributeCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeCategoryApi(config);
            }
        }

        public IAttributeTemplateApi AttributeTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeTemplateApi(config);
            }
        }

        public IAttributeTraitApi AttributeTrait
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeTraitApi(config);
            }
        }



        public ICalculationApi Calculation
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new CalculationApi(config);
            }
        }

        public IConfigurationApi Configuration
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ConfigurationApi(config);
            }
        }

        public IDataServerApi DataServer
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new DataServerApi(config);
            }
        }

        public IElementApi Element
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementApi(config);
            }
        }

        public IElementCategoryApi ElementCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementCategoryApi(config);
            }
        }

        public IElementTemplateApi ElementTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementTemplateApi(config);
            }
        }


        public IEnumerationSetApi EnumerationSet
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EnumerationSetApi(config);
            }
        }

        public IEnumerationValueApi EnumerationValue
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EnumerationValueApi(config);
            }
        }

        public IEventFrameApi EventFrame
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EventFrameApi(config);
            }
        }

        public IHomeApi Home
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new HomeApi(config);
            }
        }


        public INotificationContactTemplateApi NotificationContactTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationContactTemplateApi(config);
            }
        }

        public INotificationRuleApi NotificationRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleApi(config);
            }
        }

        public INotificationRuleSubscriberApi NotificationRuleSubscriber
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleSubscriberApi(config);
            }
        }

        public INotificationRuleTemplateApi NotificationRuleTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleTemplateApi(config);
            }
        }


        public IPointApi Point
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new PointApi(config);
            }
        }

        public ISecurityIdentityApi SecurityIdentity
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SecurityIdentityApi(config);
            }
        }

        public ISecurityMappingApi SecurityMapping
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SecurityMappingApi(config);
            }
        }

        public IStreamApi Stream
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new StreamApi(config);
            }
        }

        public IStreamSetApi StreamSet
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new StreamSetApi(config);
            }
        }


        public ISystemApi System
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SystemApi(config);
            }
        }

        public ITableApi Table
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TableApi(config);
            }
        }

        public ITableCategoryApi TableCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TableCategoryApi(config);
            }
        }

        public ITimeRuleApi TimeRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TimeRuleApi(config);
            }
        }

        public ITimeRulePlugInApi TimeRulePlugIn
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TimeRulePlugInApi(config);
            }
        }

        public IUnitApi Unit
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new UnitApi(config);
            }
        }
        public IUnitClassApi UnitClass
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new UnitClassApi(config);
            }
        }

        public WebIdHelper WebIdHelper
        {
            get
            {
                return new WebIdHelper();
            }
        }
    }
}
