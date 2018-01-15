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

	[Guid("639E3434-0ADB-419E-B0FD-D8A4671D4A96")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamValue
	{
		[DispId(1)]
		PIStreamValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("049115B4-73E3-44FA-BA5E-79C667325BD0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamValue")]
	[DataContract]

	public class PIItemsStreamValue : IPIItemsStreamValue
	{
		public PIItemsStreamValue()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
