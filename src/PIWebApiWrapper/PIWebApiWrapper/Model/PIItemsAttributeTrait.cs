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

	[Guid("A685B41B-8E2D-4261-B650-6605B4C579E1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttributeTrait
	{
		[DispId(1)]
		PIAttributeTrait[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttributeTrait GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttributeTrait values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("CBC9A024-7EFC-43C5-AE64-FF17ADE4615A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttributeTrait))]
	[ProgId("PIWebAPIWrapper.PIItemsAttributeTrait")]
	[DataContract]

	public class PIItemsAttributeTrait : IPIItemsAttributeTrait
	{
		public PIItemsAttributeTrait()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttributeTrait[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttributeTrait GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttributeTrait values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttributeTrait[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
