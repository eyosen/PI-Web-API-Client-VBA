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

	[Guid("68EF0812-BD1D-4410-9656-26C6F0669930")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsCacheInstance
	{
		[DispId(1)]
		PICacheInstance[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PICacheInstance GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PICacheInstance values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("23C5E328-F588-4C93-A856-52006A8AB6B9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.PIItemsCacheInstance")]
	[DataContract]

	public class PIItemsCacheInstance : IPIItemsCacheInstance
	{
		public PIItemsCacheInstance()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PICacheInstance[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PICacheInstance GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PICacheInstance values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PICacheInstance[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
