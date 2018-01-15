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

	[Guid("0F833233-DB5E-4B76-AF70-FE9F0A0B0D82")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemElement
	{
		[DispId(1)]
		PIItemElement[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemElement GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemElement values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("9E70E64C-4A42-40F2-86FB-BF21C9037667")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemElement))]
	[ProgId("PIWebAPIWrapper.PIItemsItemElement")]
	[DataContract]

	public class PIItemsItemElement : IPIItemsItemElement
	{
		public PIItemsItemElement()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemElement[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemElement GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemElement values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemElement[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
