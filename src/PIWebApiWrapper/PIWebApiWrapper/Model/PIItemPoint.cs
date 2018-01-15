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

	[Guid("693C1218-73A0-4B76-9FB0-C5AD5905556F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemPoint
	{
		[DispId(1)]
		string Identifier { get; set; }

		[DispId(2)]
		string IdentifierType { get; set; }

		[DispId(3)]
		PIPoint Object { get; set; }

		[DispId(4)]
		PIErrors Exception { get; set; }

	}

	[Guid("DDAF7A42-4E40-4316-A4E9-A16E8D492BF5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemPoint))]
	[ProgId("PIWebAPIWrapper.PIItemPoint")]
	[DataContract]

	public class PIItemPoint : IPIItemPoint
	{
		public PIItemPoint()
		{
		}

		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIPoint Object { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
