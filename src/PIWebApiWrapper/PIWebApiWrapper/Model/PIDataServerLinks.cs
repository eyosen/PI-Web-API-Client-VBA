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

	[Guid("00CC9705-5D42-47B7-A26E-4C0A334C23EB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIDataServerLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Points { get; set; }

		[DispId(3)]
		string EnumerationSets { get; set; }

	}

	[Guid("A9BDE854-822E-4394-832D-FF61B011683F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIDataServerLinks))]
	[ProgId("PIWebAPIWrapper.PIDataServerLinks")]
	[DataContract]

	public class PIDataServerLinks : IPIDataServerLinks
	{
		public PIDataServerLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Points", EmitDefaultValue = false)]
		public string Points { get; set; }

		[DataMember(Name = "EnumerationSets", EmitDefaultValue = false)]
		public string EnumerationSets { get; set; }

	}
}
