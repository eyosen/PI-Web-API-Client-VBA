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

	[Guid("44B86EBC-1657-4E8F-8EEE-5BEB53B0716C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemAttribute
	{
		[DispId(1)]
		PIItemAttribute[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemAttribute GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemAttribute values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("68B997BB-82F2-45C1-AE05-7349DA0F8764")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemAttribute))]
	[ProgId("PIWebAPIWrapper.PIItemsItemAttribute")]
	[DataContract]

	public class PIItemsItemAttribute : IPIItemsItemAttribute
	{
		public PIItemsItemAttribute()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemAttribute[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemAttribute GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemAttribute values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemAttribute[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
