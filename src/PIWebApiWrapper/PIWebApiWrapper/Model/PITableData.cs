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

	[Guid("8F8A3300-080E-4041-8D9F-209BAEDBB09F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITableData
	{
		[DispId(1)]
		object Columns { get; set; }

		[DispId(2)]
		object[] Rows { get; set; }

	}

	[Guid("A53700B7-F063-4E4F-B8A0-A3C5AFF274F5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITableData))]
	[ProgId("PIWebAPIWrapper.PITableData")]
	[DataContract]

	public class PITableData : IPITableData
	{
		public PITableData()
		{
		}

		[DataMember(Name = "Columns", EmitDefaultValue = false)]
		public object Columns { get; set; }

		[DataMember(Name = "Rows", EmitDefaultValue = false)]
		public object[] Rows { get; set; }

	}
}
