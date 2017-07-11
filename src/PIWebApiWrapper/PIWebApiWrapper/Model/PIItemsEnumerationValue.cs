// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("AE29FE9E-A6CC-46D7-8AE4-3B47F1F336B1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsEnumerationValue
	{
		[DispId(1)]
		PIEnumerationValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIEnumerationValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIEnumerationValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("51D4AD29-B124-4F08-8514-A1F71C71F3A6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsEnumerationValue))]
	[ProgId("PIWebAPIWrapper.PIItemsEnumerationValue")]
	[DataContract]

	public class PIItemsEnumerationValue : IPIItemsEnumerationValue
	{
		public PIItemsEnumerationValue()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIEnumerationValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIEnumerationValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIEnumerationValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIEnumerationValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
