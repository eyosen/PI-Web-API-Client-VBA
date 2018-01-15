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

	[Guid("5F728BAB-7F92-4B84-A66B-92B84EE5F42C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysis
	{
		[DispId(1)]
		PIAnalysis[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysis GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysis values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("7EF1574C-68F9-4850-9A03-31E9587DAD81")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysis))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysis")]
	[DataContract]

	public class PIItemsAnalysis : IPIItemsAnalysis
	{
		public PIItemsAnalysis()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysis[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysis GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysis values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysis[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
