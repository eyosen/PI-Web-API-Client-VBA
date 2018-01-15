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

	[Guid("4B05486E-3FEB-4E0E-851B-A6DCF7BE72D5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisRulePlugIn
	{
		[DispId(1)]
		PIAnalysisRulePlugIn[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisRulePlugIn GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisRulePlugIn values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("27AAB03D-96A5-492E-9EBA-7365C2545B4D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisRulePlugIn")]
	[DataContract]

	public class PIItemsAnalysisRulePlugIn : IPIItemsAnalysisRulePlugIn
	{
		public PIItemsAnalysisRulePlugIn()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisRulePlugIn[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisRulePlugIn GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisRulePlugIn values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisRulePlugIn[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
