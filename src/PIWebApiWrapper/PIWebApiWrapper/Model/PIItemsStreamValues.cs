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

	[Guid("97A854DE-CA63-40E5-8DF3-A9C85301256D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamValues
	{
		[DispId(1)]
		PIStreamValues[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamValues GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamValues values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("5407A568-8AC3-469E-AB92-148073A22DCD")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamValues))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamValues")]
	[DataContract]

	public class PIItemsStreamValues : IPIItemsStreamValues
	{
		public PIItemsStreamValues()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamValues[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamValues GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamValues values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamValues[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
