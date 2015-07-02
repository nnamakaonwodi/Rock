//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for Person that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class PersonEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public DateTime? AnniversaryDate { get; set; }

        /// <summary />
        public int? BirthDay { get; set; }

        /// <summary />
        public int? BirthMonth { get; set; }

        /// <summary />
        public int? BirthYear { get; set; }

        /// <summary />
        public int? ConnectionStatusValueId { get; set; }

        /// <summary />
        public string Email { get; set; }

        /// <summary />
        public string EmailNote { get; set; }

        /// <summary />
        public Rock.Client.Enums.EmailPreference EmailPreference { get; set; }

        /// <summary />
        public string FirstName { get; set; }

        /// <summary />
        public Rock.Client.Enums.Gender Gender { get; set; }

        /// <summary />
        public int? GivingGroupId { get; set; }

        /// <summary />
        public int? GraduationYear { get; set; }

        /// <summary />
        public string InactiveReasonNote { get; set; }

        /// <summary />
        public bool IsDeceased { get; set; }

        /// <summary />
        public bool? IsEmailActive { get; set; }

        /// <summary />
        public bool IsSystem { get; set; }

        /// <summary />
        public string LastName { get; set; }

        /// <summary />
        public int? MaritalStatusValueId { get; set; }

        /// <summary />
        public string MiddleName { get; set; }

        /// <summary />
        public string NickName { get; set; }

        /// <summary />
        public int? PhotoId { get; set; }

        /// <summary />
        public int? RecordStatusReasonValueId { get; set; }

        /// <summary />
        public int? RecordStatusValueId { get; set; }

        /// <summary />
        public int? RecordTypeValueId { get; set; }

        /// <summary />
        public string ReviewReasonNote { get; set; }

        /// <summary />
        public int? ReviewReasonValueId { get; set; }

        /// <summary />
        public int? SuffixValueId { get; set; }

        /// <summary />
        public string SystemNote { get; set; }

        /// <summary />
        public int? TitleValueId { get; set; }

        /// <summary />
        public int? ViewedCount { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public string ForeignId { get; set; }

    }

    /// <summary>
    /// Client model for Person that includes all the fields that are available for GETs. Use this for GETs (use PersonEntity for POST/PUTs)
    /// </summary>
    public partial class Person : PersonEntity
    {
        /// <summary />
        public DateTime? BirthDate { get; set; }

        /// <summary />
        public DefinedValue ConnectionStatusValue { get; set; }

        /// <summary />
        public int? DaysUntilBirthday { get; set; }

        /// <summary />
        public string GivingId { get; set; }

        /// <summary />
        public int GivingLeaderId { get; set; }

        /// <summary>
        /// The Grade Offset of the person, which is the number of years until their graduation date
        /// </summary>
        public int? GradeOffset { get; set; }

        /// <summary />
        public DefinedValue MaritalStatusValue { get; set; }

        /// <summary />
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary />
        public BinaryFile Photo { get; set; }

        /// <summary>
        /// The Primary PersonAliasId of the Person
        /// </summary>
        public int? PrimaryAliasId { get; set; }

        /// <summary />
        public DefinedValue RecordStatusReasonValue { get; set; }

        /// <summary />
        public DefinedValue RecordStatusValue { get; set; }

        /// <summary />
        public DefinedValue RecordTypeValue { get; set; }

        /// <summary />
        public DefinedValue ReviewReasonValue { get; set; }

        /// <summary />
        public DefinedValue SuffixValue { get; set; }

        /// <summary />
        public DefinedValue TitleValue { get; set; }

        /// <summary />
        public ICollection<UserLogin> Users { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
