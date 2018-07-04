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

	[Guid("1B165DC7-EC12-44E8-8381-C1F7DAAC39AE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIExtendedTimedValues
	{
		[DispId(1)]
		PIExtendedTimedValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIExtendedTimedValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIExtendedTimedValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		string UnitsAbbreviation { get; set; }

		[DispId(7)]
		PIWebException WebException { get; set; }

	}

	[Guid("F0FF7A5D-A927-44A3-983C-966FEA1A4018")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIExtendedTimedValues))]
	[ProgId("PIWebAPIWrapper.PIExtendedTimedValues")]
	[DataContract]

	public class PIExtendedTimedValues : IPIExtendedTimedValues
	{
		public PIExtendedTimedValues()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIExtendedTimedValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIExtendedTimedValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIExtendedTimedValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIExtendedTimedValue[i];
		}

		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
