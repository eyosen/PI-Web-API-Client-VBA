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

	[Guid("E0156667-3C23-4900-BBE6-F093F49E7E52")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimedValues
	{
		[DispId(1)]
		PITimedValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITimedValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITimedValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		string UnitsAbbreviation { get; set; }

		[DispId(7)]
		PIWebException WebException { get; set; }

	}

	[Guid("AF2A8541-EC42-46E1-B417-8335E424A0B6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimedValues))]
	[ProgId("PIWebAPIWrapper.PITimedValues")]
	[DataContract]

	public class PITimedValues : IPITimedValues
	{
		public PITimedValues()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITimedValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITimedValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITimedValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITimedValue[i];
		}

		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
