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

	[Guid("5FE57171-A8E2-4A88-A1C1-6922423591B8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisRuleLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AnalysisRules { get; set; }

		[DispId(3)]
		string Analysis { get; set; }

		[DispId(4)]
		string AnalysisTemplate { get; set; }

		[DispId(5)]
		string Parent { get; set; }

		[DispId(6)]
		string PlugIn { get; set; }

	}

	[Guid("7CF7DB29-1355-4E4F-9EF3-404A23FAA88F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisRuleLinks))]
	[ProgId("PIWebAPIWrapper.PIAnalysisRuleLinks")]
	[DataContract]

	public class PIAnalysisRuleLinks : IPIAnalysisRuleLinks
	{
		public PIAnalysisRuleLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AnalysisRules", EmitDefaultValue = false)]
		public string AnalysisRules { get; set; }

		[DataMember(Name = "Analysis", EmitDefaultValue = false)]
		public string Analysis { get; set; }

		[DataMember(Name = "AnalysisTemplate", EmitDefaultValue = false)]
		public string AnalysisTemplate { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "PlugIn", EmitDefaultValue = false)]
		public string PlugIn { get; set; }

	}
}
