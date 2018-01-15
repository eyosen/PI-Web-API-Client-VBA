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

	[Guid("2DADD180-C1A4-4623-A03F-3DA231C650BD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnit
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Abbreviation { get; set; }

		[DispId(5)]
		string Description { get; set; }

		[DispId(6)]
		string Path { get; set; }

		[DispId(7)]
		double Factor { get; set; }

		[DispId(8)]
		double Offset { get; set; }

		[DispId(9)]
		double ReferenceFactor { get; set; }

		[DispId(10)]
		double ReferenceOffset { get; set; }

		[DispId(11)]
		string ReferenceUnitAbbreviation { get; set; }

		[DispId(12)]
		object Links { get; set; }

	}

	[Guid("6217A9F6-294E-41C7-A326-500FC30D9966")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnit))]
	[ProgId("PIWebAPIWrapper.PIUnit")]
	[DataContract]

	public class PIUnit : IPIUnit
	{
		public PIUnit()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Abbreviation", EmitDefaultValue = false)]
		public string Abbreviation { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Factor", EmitDefaultValue = false)]
		public double Factor { get; set; }

		[DataMember(Name = "Offset", EmitDefaultValue = false)]
		public double Offset { get; set; }

		[DataMember(Name = "ReferenceFactor", EmitDefaultValue = false)]
		public double ReferenceFactor { get; set; }

		[DataMember(Name = "ReferenceOffset", EmitDefaultValue = false)]
		public double ReferenceOffset { get; set; }

		[DataMember(Name = "ReferenceUnitAbbreviation", EmitDefaultValue = false)]
		public string ReferenceUnitAbbreviation { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
