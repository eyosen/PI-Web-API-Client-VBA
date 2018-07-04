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

	[Guid("78B223E8-B2AB-42B7-ACCC-8447B70BA56E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsstring
	{
		[DispId(1)]
		string[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		string GetItem(int i);

		[DispId(4)]
		void SetItem(int i, string values);

		[DispId(5)]
		void CreateItemsArray(int i);

	}

	[Guid("5594208D-B84A-4733-939B-20B31DF0FF1C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsstring))]
	[ProgId("PIWebAPIWrapper.PIItemsstring")]
	[DataContract]

	public class PIItemsstring : IPIItemsstring
	{
		public PIItemsstring()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public string[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public string GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, string values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new string[i];
		}

	}
}
