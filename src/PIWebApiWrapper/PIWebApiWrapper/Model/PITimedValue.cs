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

	[Guid("2B905BAE-B82A-44D9-9A26-234EDC71C724")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimedValue
	{
		[DispId(1)]
		string Timestamp { get; set; }

		[DispId(2)]
		string UnitsAbbreviation { get; set; }

		[DispId(3)]
		bool Good { get; set; }

		[DispId(4)]
		bool Questionable { get; set; }

		[DispId(5)]
		bool Substituted { get; set; }

		[DispId(6)]
		object Value { get; set; }

		[DispId(7)]
		void SetValueWithString(string value);

		[DispId(8)]
		void SetValueWithInt(int value);

		[DispId(9)]
		void SetValueWithDouble(double value);

		[DispId(10)]
		PIErrors Exception { get; set; }

	}

	[Guid("2E754540-55BA-4B7C-A7C4-88C90D5C139E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimedValue))]
	[ProgId("PIWebAPIWrapper.PITimedValue")]
	[DataContract]

	public class PITimedValue : IPITimedValue
	{
		public PITimedValue()
		{
		}

		[DataMember(Name = "Timestamp", EmitDefaultValue = false)]
		public string Timestamp { get; set; }

		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		[DataMember(Name = "Good", EmitDefaultValue = false)]
		public bool Good { get; set; }

		[DataMember(Name = "Questionable", EmitDefaultValue = false)]
		public bool Questionable { get; set; }

		[DataMember(Name = "Substituted", EmitDefaultValue = false)]
		public bool Substituted { get; set; }

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

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
