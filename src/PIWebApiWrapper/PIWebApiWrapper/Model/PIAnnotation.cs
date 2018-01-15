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

	[Guid("40126A7E-17CD-4C05-8A1B-83EA636B39F8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnnotation
	{
		[DispId(1)]
		string Id { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Description { get; set; }

		[DispId(4)]
		object Value { get; set; }

		[DispId(5)]
		void SetValueWithString(string value);

		[DispId(6)]
		void SetValueWithInt(int value);

		[DispId(7)]
		void SetValueWithDouble(double value);

		[DispId(8)]
		string Creator { get; set; }

		[DispId(9)]
		string CreationDate { get; set; }

		[DispId(10)]
		string Modifier { get; set; }

		[DispId(11)]
		string ModifyDate { get; set; }

		[DispId(12)]
		object Links { get; set; }

	}

	[Guid("C5BC09EC-C1E9-4214-B0D0-D7F4552B3459")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnnotation))]
	[ProgId("PIWebAPIWrapper.PIAnnotation")]
	[DataContract]

	public class PIAnnotation : IPIAnnotation
	{
		public PIAnnotation()
		{
		}

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public object Value { get; set; }

		public void SetValueWithString(string value)
		{
			Value = value;
		}

		public void SetValueWithInt(int value)
		{
			Value = value;
		}

		public void SetValueWithDouble(double value)
		{
			Value = value;
		}

		[DataMember(Name = "Creator", EmitDefaultValue = false)]
		public string Creator { get; set; }

		[DataMember(Name = "CreationDate", EmitDefaultValue = false)]
		public string CreationDate { get; set; }

		[DataMember(Name = "Modifier", EmitDefaultValue = false)]
		public string Modifier { get; set; }

		[DataMember(Name = "ModifyDate", EmitDefaultValue = false)]
		public string ModifyDate { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
