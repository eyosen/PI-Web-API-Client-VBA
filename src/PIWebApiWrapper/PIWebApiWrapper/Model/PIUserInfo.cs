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

	[Guid("027FF524-75F5-4C0D-AEE8-EDED8D1AAE70")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUserInfo
	{
		[DispId(1)]
		string IdentityType { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		bool IsAuthenticated { get; set; }

		[DispId(4)]
		string SID { get; set; }

		[DispId(5)]
		string ImpersonationLevel { get; set; }

		[DispId(6)]
		PIWebException WebException { get; set; }

	}

	[Guid("C11C0462-7E29-4B38-8DD4-70FE8D16FA16")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUserInfo))]
	[ProgId("PIWebAPIWrapper.PIUserInfo")]
	[DataContract]

	public class PIUserInfo : IPIUserInfo
	{
		public PIUserInfo()
		{
		}

		[DataMember(Name = "IdentityType", EmitDefaultValue = false)]
		public string IdentityType { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "IsAuthenticated", EmitDefaultValue = false)]
		public bool IsAuthenticated { get; set; }

		[DataMember(Name = "SID", EmitDefaultValue = false)]
		public string SID { get; set; }

		[DataMember(Name = "ImpersonationLevel", EmitDefaultValue = false)]
		public string ImpersonationLevel { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
