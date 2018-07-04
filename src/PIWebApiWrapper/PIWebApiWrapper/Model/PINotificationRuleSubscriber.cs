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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("3F4C528E-DC6D-411A-A9BD-F057927E3147")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPINotificationRuleSubscriber
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		string Path { get; set; }

		[DispId(6)]
		string ConfigString { get; set; }

		[DispId(7)]
		string ContactTemplateName { get; set; }

		[DispId(8)]
		string ContactType { get; set; }

		[DispId(9)]
		string DeliveryFormatName { get; set; }

		[DispId(10)]
		string PlugInName { get; set; }

		[DispId(11)]
		string EscalationTimeout { get; set; }

		[DispId(12)]
		int MaximumRetries { get; set; }

		[DispId(13)]
		string NotifyOption { get; set; }

		[DispId(14)]
		string RetryInterval { get; set; }

		[DispId(15)]
		PIWebException WebException { get; set; }

	}

	[Guid("6770A2BA-C0D1-4F7B-ABEB-4F76CD2BF16B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPINotificationRuleSubscriber))]
	[ProgId("PIWebAPIWrapper.PINotificationRuleSubscriber")]
	[DataContract]

	public class PINotificationRuleSubscriber : IPINotificationRuleSubscriber
	{
		public PINotificationRuleSubscriber()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		[DataMember(Name = "ContactTemplateName", EmitDefaultValue = false)]
		public string ContactTemplateName { get; set; }

		[DataMember(Name = "ContactType", EmitDefaultValue = false)]
		public string ContactType { get; set; }

		[DataMember(Name = "DeliveryFormatName", EmitDefaultValue = false)]
		public string DeliveryFormatName { get; set; }

		[DataMember(Name = "PlugInName", EmitDefaultValue = false)]
		public string PlugInName { get; set; }

		[DataMember(Name = "EscalationTimeout", EmitDefaultValue = false)]
		public string EscalationTimeout { get; set; }

		[DataMember(Name = "MaximumRetries", EmitDefaultValue = false)]
		public int MaximumRetries { get; set; }

		[DataMember(Name = "NotifyOption", EmitDefaultValue = false)]
		public string NotifyOption { get; set; }

		[DataMember(Name = "RetryInterval", EmitDefaultValue = false)]
		public string RetryInterval { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
