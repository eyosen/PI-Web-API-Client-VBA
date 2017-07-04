// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("8F8FE758-B9D6-4251-86A3-D0ACCB75826F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIResponse
	{
		[DispId(1)]
		int Status { get; set; }

		[DispId(2)]
		object Headers { get; set; }

		[DispId(3)]
		object Content { get; set; }

	}

	[Guid("6B60DEAE-680D-4006-BFCD-48BFD71D5C6E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIResponse))]
	[ProgId("PIWebAPIWrapper.PIResponse")]
	[DataContract]

	public class PIResponse : IPIResponse
	{
		public PIResponse()
		{
		}

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int Status { get; set; }

		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public object Headers { get; set; }

		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public object Content { get; set; }

	}
}
