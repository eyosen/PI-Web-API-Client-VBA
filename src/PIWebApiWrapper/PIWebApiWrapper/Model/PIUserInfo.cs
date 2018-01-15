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

	[Guid("9E820A1D-A657-4A64-9E36-A6541FF25998")]
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

	}

	[Guid("86B4AF9F-2889-4B71-B0CA-05AD5A91E7E9")]
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

	}
}
