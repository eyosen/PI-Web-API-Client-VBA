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

	[Guid("A37B1DEF-636B-4AFB-AD1E-FFE9FABAC5FD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPointAttribute
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		object Value { get; set; }

		[DispId(3)]
		void SetValueWithString(string value);

		[DispId(4)]
		void SetValueWithInt(int value);

		[DispId(5)]
		void SetValueWithDouble(double value);

		[DispId(6)]
		PIPointAttributeLinks Links { get; set; }

		[DispId(7)]
		PIWebException WebException { get; set; }

	}

	[Guid("92C97662-1D09-4A76-AAED-41D1F709245F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPointAttribute))]
	[ProgId("PIWebAPIWrapper.PIPointAttribute")]
	[DataContract]

	public class PIPointAttribute : IPIPointAttribute
	{
		public PIPointAttribute()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

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

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPointAttributeLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
