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

	[Guid("37EC5ECF-A3BA-40F5-8A98-2DE574BC118C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisTemplateLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Database { get; set; }

		[DispId(3)]
		string Categories { get; set; }

		[DispId(4)]
		string AnalysisRule { get; set; }

		[DispId(5)]
		string AnalysisRulePlugIn { get; set; }

		[DispId(6)]
		string TimeRule { get; set; }

		[DispId(7)]
		string TimeRulePlugIn { get; set; }

		[DispId(8)]
		string Target { get; set; }

		[DispId(9)]
		string Security { get; set; }

		[DispId(10)]
		string SecurityEntries { get; set; }

	}

	[Guid("0FCA600B-BC6E-4784-9FEF-66C30F8847E4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisTemplateLinks))]
	[ProgId("PIWebAPIWrapper.PIAnalysisTemplateLinks")]
	[DataContract]

	public class PIAnalysisTemplateLinks : IPIAnalysisTemplateLinks
	{
		public PIAnalysisTemplateLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "AnalysisRule", EmitDefaultValue = false)]
		public string AnalysisRule { get; set; }

		[DataMember(Name = "AnalysisRulePlugIn", EmitDefaultValue = false)]
		public string AnalysisRulePlugIn { get; set; }

		[DataMember(Name = "TimeRule", EmitDefaultValue = false)]
		public string TimeRule { get; set; }

		[DataMember(Name = "TimeRulePlugIn", EmitDefaultValue = false)]
		public string TimeRulePlugIn { get; set; }

		[DataMember(Name = "Target", EmitDefaultValue = false)]
		public string Target { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
