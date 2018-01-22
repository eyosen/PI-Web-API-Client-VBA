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

	[Guid("FD4337F6-517D-441B-861F-E61CC7E33540")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPoint
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		int Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Path { get; set; }

		[DispId(5)]
		string Descriptor { get; set; }

		[DispId(6)]
		string PointClass { get; set; }

		[DispId(7)]
		string PointType { get; set; }

		[DispId(8)]
		string DigitalSetName { get; set; }

		[DispId(9)]
		string EngineeringUnits { get; set; }

		[DispId(10)]
		bool Step { get; set; }

		[DispId(11)]
		bool Future { get; set; }

		[DispId(12)]
		PIPointLinks Links { get; set; }

		[DispId(13)]
		PIWebException WebException { get; set; }

	}

	[Guid("AF435DBF-51A2-44BF-982C-081A990E542B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPoint))]
	[ProgId("PIWebAPIWrapper.PIPoint")]
	[DataContract]

	public class PIPoint : IPIPoint
	{
		public PIPoint()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public int Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Descriptor", EmitDefaultValue = false)]
		public string Descriptor { get; set; }

		[DataMember(Name = "PointClass", EmitDefaultValue = false)]
		public string PointClass { get; set; }

		[DataMember(Name = "PointType", EmitDefaultValue = false)]
		public string PointType { get; set; }

		[DataMember(Name = "DigitalSetName", EmitDefaultValue = false)]
		public string DigitalSetName { get; set; }

		[DataMember(Name = "EngineeringUnits", EmitDefaultValue = false)]
		public string EngineeringUnits { get; set; }

		[DataMember(Name = "Step", EmitDefaultValue = false)]
		public bool Step { get; set; }

		[DataMember(Name = "Future", EmitDefaultValue = false)]
		public bool Future { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPointLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
