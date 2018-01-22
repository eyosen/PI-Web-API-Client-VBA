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

	[Guid("32717844-289E-40ED-B28A-486CC421B66F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISubstatus
	{
		[DispId(1)]
		int Substatus { get; set; }

		[DispId(2)]
		string Message { get; set; }

		[DispId(3)]
		PIWebException WebException { get; set; }

	}

	[Guid("1F4EA010-49FE-4ECF-B004-B4606122BBBF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISubstatus))]
	[ProgId("PIWebAPIWrapper.PISubstatus")]
	[DataContract]

	public class PISubstatus : IPISubstatus
	{
		public PISubstatus()
		{
		}

		[DataMember(Name = "Substatus", EmitDefaultValue = false)]
		public int Substatus { get; set; }

		[DataMember(Name = "Message", EmitDefaultValue = false)]
		public string Message { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
