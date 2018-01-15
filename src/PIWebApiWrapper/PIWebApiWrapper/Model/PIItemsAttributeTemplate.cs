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

	[Guid("83DDCF6F-60F0-44E0-A39B-D19242ADF68B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttributeTemplate
	{
		[DispId(1)]
		PIAttributeTemplate[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttributeTemplate GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttributeTemplate values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("2C65ABAA-1A7C-48D7-8B93-353AE10EAD39")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.PIItemsAttributeTemplate")]
	[DataContract]

	public class PIItemsAttributeTemplate : IPIItemsAttributeTemplate
	{
		public PIItemsAttributeTemplate()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttributeTemplate[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttributeTemplate GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttributeTemplate values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttributeTemplate[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
