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

	[Guid("2ADA82A8-DEEC-4E5C-93F0-979884638FB0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIDataServerLicense
	{
		[DispId(1)]
		string AmountLeft { get; set; }

		[DispId(2)]
		string AmountUsed { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string TotalAmount { get; set; }

		[DispId(5)]
		PIDataServerLicenseLinks Links { get; set; }

		[DispId(6)]
		PIWebException WebException { get; set; }

	}

	[Guid("9C6A65E8-13C9-42D6-8AF8-0A03AF6FDD0A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIDataServerLicense))]
	[ProgId("PIWebAPIWrapper.PIDataServerLicense")]
	[DataContract]

	public class PIDataServerLicense : IPIDataServerLicense
	{
		public PIDataServerLicense()
		{
		}

		[DataMember(Name = "AmountLeft", EmitDefaultValue = false)]
		public string AmountLeft { get; set; }

		[DataMember(Name = "AmountUsed", EmitDefaultValue = false)]
		public string AmountUsed { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
		public string TotalAmount { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIDataServerLicenseLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
