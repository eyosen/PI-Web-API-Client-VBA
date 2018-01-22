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

	[Guid("2CC86536-D744-4259-AF61-A9AE2395E53A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurity
	{
		[DispId(1)]
		bool CanAnnotate { get; set; }

		[DispId(2)]
		bool CanDelete { get; set; }

		[DispId(3)]
		bool CanExecute { get; set; }

		[DispId(4)]
		bool CanRead { get; set; }

		[DispId(5)]
		bool CanReadData { get; set; }

		[DispId(6)]
		bool CanSubscribe { get; set; }

		[DispId(7)]
		bool CanSubscribeOthers { get; set; }

		[DispId(8)]
		bool CanWrite { get; set; }

		[DispId(9)]
		bool CanWriteData { get; set; }

		[DispId(10)]
		bool HasAdmin { get; set; }

		[DispId(11)]
		string[] Rights { get; set; }

		[DispId(12)]
		PIWebException WebException { get; set; }

	}

	[Guid("B6F73B21-2347-4E80-A5FC-E4EE751D64F1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurity))]
	[ProgId("PIWebAPIWrapper.PISecurity")]
	[DataContract]

	public class PISecurity : IPISecurity
	{
		public PISecurity()
		{
		}

		[DataMember(Name = "CanAnnotate", EmitDefaultValue = false)]
		public bool CanAnnotate { get; set; }

		[DataMember(Name = "CanDelete", EmitDefaultValue = false)]
		public bool CanDelete { get; set; }

		[DataMember(Name = "CanExecute", EmitDefaultValue = false)]
		public bool CanExecute { get; set; }

		[DataMember(Name = "CanRead", EmitDefaultValue = false)]
		public bool CanRead { get; set; }

		[DataMember(Name = "CanReadData", EmitDefaultValue = false)]
		public bool CanReadData { get; set; }

		[DataMember(Name = "CanSubscribe", EmitDefaultValue = false)]
		public bool CanSubscribe { get; set; }

		[DataMember(Name = "CanSubscribeOthers", EmitDefaultValue = false)]
		public bool CanSubscribeOthers { get; set; }

		[DataMember(Name = "CanWrite", EmitDefaultValue = false)]
		public bool CanWrite { get; set; }

		[DataMember(Name = "CanWriteData", EmitDefaultValue = false)]
		public bool CanWriteData { get; set; }

		[DataMember(Name = "HasAdmin", EmitDefaultValue = false)]
		public bool HasAdmin { get; set; }

		[DataMember(Name = "Rights", EmitDefaultValue = false)]
		public string[] Rights { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
