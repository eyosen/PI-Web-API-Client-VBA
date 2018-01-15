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

	[Guid("D549B844-F5E5-4B20-882C-CD06EDB6B394")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisRule
	{
		[DispId(1)]
		PIAnalysisRule[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisRule GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisRule values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("D6A5A3AE-DCB0-4B74-ABA6-35AF08857AC7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisRule))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisRule")]
	[DataContract]

	public class PIItemsAnalysisRule : IPIItemsAnalysisRule
	{
		public PIItemsAnalysisRule()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisRule[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisRule GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisRule values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisRule[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
