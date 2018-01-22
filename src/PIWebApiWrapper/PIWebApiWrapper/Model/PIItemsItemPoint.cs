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

	[Guid("6BC58E60-F75F-433C-A099-AA2E619F6977")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemPoint
	{
		[DispId(1)]
		PIItemPoint[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemPoint GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemPoint values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("9E5AF72D-D684-4912-B0E6-EDA47298F1AB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemPoint))]
	[ProgId("PIWebAPIWrapper.PIItemsItemPoint")]
	[DataContract]

	public class PIItemsItemPoint : IPIItemsItemPoint
	{
		public PIItemsItemPoint()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemPoint[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemPoint GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemPoint values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemPoint[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
