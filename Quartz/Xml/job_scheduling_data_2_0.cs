﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace Quartz.Xml.JobSchedulingData20 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    [System.Xml.Serialization.XmlRootAttribute("job-scheduling-data", Namespace="http://quartznet.sourceforge.net/JobSchedulingData", IsNullable=false)]
    public partial class QuartzXmlConfiguration20
    {
        
        private preprocessingcommandsType[] preprocessingcommandsField;
        
        private processingdirectivesType[] processingdirectivesField;
        
        private jobschedulingdataSchedule[] scheduleField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pre-processing-commands")]
        public preprocessingcommandsType[] preprocessingcommands {
            get {
                return this.preprocessingcommandsField;
            }
            set {
                this.preprocessingcommandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("processing-directives")]
        public processingdirectivesType[] processingdirectives {
            get {
                return this.processingdirectivesField;
            }
            set {
                this.processingdirectivesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schedule")]
        public jobschedulingdataSchedule[] schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="pre-processing-commandsType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsType {
        
        private string[] deletejobsingroupField;
        
        private string[] deletetriggersingroupField;
        
        private preprocessingcommandsTypeDeletejob[] deletejobField;
        
        private preprocessingcommandsTypeDeletetrigger[] deletetriggerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delete-jobs-in-group")]
        public string[] deletejobsingroup {
            get {
                return this.deletejobsingroupField;
            }
            set {
                this.deletejobsingroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delete-triggers-in-group")]
        public string[] deletetriggersingroup {
            get {
                return this.deletetriggersingroupField;
            }
            set {
                this.deletetriggersingroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delete-job")]
        public preprocessingcommandsTypeDeletejob[] deletejob {
            get {
                return this.deletejobField;
            }
            set {
                this.deletejobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delete-trigger")]
        public preprocessingcommandsTypeDeletetrigger[] deletetrigger {
            get {
                return this.deletetriggerField;
            }
            set {
                this.deletetriggerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsTypeDeletejob {
        
        private string nameField;
        
        private string groupField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(calendarIntervalTriggerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(cronTriggerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(simpleTriggerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public abstract partial class abstractTriggerType {
        
        private string nameField;
        
        private string groupField;
        
        private string descriptionField;
        
        private string jobnameField;
        
        private string jobgroupField;
        
        private string priorityField;
        
        private string calendarnameField;
        
        private jobdatamapType jobdatamapField;
        
        private object itemField;
        
        private System.DateTime endtimeField;
        
        private bool endtimeFieldSpecified;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-name")]
        public string jobname {
            get {
                return this.jobnameField;
            }
            set {
                this.jobnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-group")]
        public string jobgroup {
            get {
                return this.jobgroupField;
            }
            set {
                this.jobgroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calendar-name")]
        public string calendarname {
            get {
                return this.calendarnameField;
            }
            set {
                this.calendarnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-data-map")]
        public jobdatamapType jobdatamap {
            get {
                return this.jobdatamapField;
            }
            set {
                this.jobdatamapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("start-time", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("start-time-seconds-in-future", typeof(string), DataType="nonNegativeInteger")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-time")]
        public System.DateTime endtime {
            get {
                return this.endtimeField;
            }
            set {
                this.endtimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endtimeSpecified {
            get {
                return this.endtimeFieldSpecified;
            }
            set {
                this.endtimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="job-data-mapType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobdatamapType {
        
        private entryType[] entryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public entryType[] entry {
            get {
                return this.entryField;
            }
            set {
                this.entryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class entryType {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class calendarIntervalTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string repeatintervalField;
        
        private string repeatintervalunitField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-interval", DataType="nonNegativeInteger")]
        public string repeatinterval {
            get {
                return this.repeatintervalField;
            }
            set {
                this.repeatintervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-interval-unit")]
        public string repeatintervalunit {
            get {
                return this.repeatintervalunitField;
            }
            set {
                this.repeatintervalunitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class cronTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string cronexpressionField;
        
        private string timezoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cron-expression")]
        public string cronexpression {
            get {
                return this.cronexpressionField;
            }
            set {
                this.cronexpressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-zone")]
        public string timezone {
            get {
                return this.timezoneField;
            }
            set {
                this.timezoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class simpleTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string repeatcountField;
        
        private string repeatintervalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-count", DataType="integer")]
        public string repeatcount {
            get {
                return this.repeatcountField;
            }
            set {
                this.repeatcountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-interval", DataType="nonNegativeInteger")]
        public string repeatinterval {
            get {
                return this.repeatintervalField;
            }
            set {
                this.repeatintervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class triggerType {
        
        private abstractTriggerType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calendar-interval", typeof(calendarIntervalTriggerType))]
        [System.Xml.Serialization.XmlElementAttribute("cron", typeof(cronTriggerType))]
        [System.Xml.Serialization.XmlElementAttribute("simple", typeof(simpleTriggerType))]
        public abstractTriggerType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="job-detailType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobdetailType {
        
        private string nameField;
        
        private string groupField;
        
        private string descriptionField;
        
        private string jobtypeField;
        
        private bool durableField;
        
        private bool recoverField;
        
        private jobdatamapType jobdatamapField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-type")]
        public string jobtype {
            get {
                return this.jobtypeField;
            }
            set {
                this.jobtypeField = value;
            }
        }
        
        /// <remarks/>
        public bool durable {
            get {
                return this.durableField;
            }
            set {
                this.durableField = value;
            }
        }
        
        /// <remarks/>
        public bool recover {
            get {
                return this.recoverField;
            }
            set {
                this.recoverField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-data-map")]
        public jobdatamapType jobdatamap {
            get {
                return this.jobdatamapField;
            }
            set {
                this.jobdatamapField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="processing-directivesType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class processingdirectivesType {
        
        private bool overwriteexistingdataField;
        
        private bool ignoreduplicatesField;
        
        public processingdirectivesType() {
            this.overwriteexistingdataField = true;
            this.ignoreduplicatesField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overwrite-existing-data")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool overwriteexistingdata {
            get {
                return this.overwriteexistingdataField;
            }
            set {
                this.overwriteexistingdataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ignore-duplicates")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ignoreduplicates {
            get {
                return this.ignoreduplicatesField;
            }
            set {
                this.ignoreduplicatesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsTypeDeletetrigger {
        
        private string nameField;
        
        private string groupField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobschedulingdataSchedule {
        
        private jobdetailType[] jobField;
        
        private triggerType[] triggerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job")]
        public jobdetailType[] job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trigger")]
        public triggerType[] trigger {
            get {
                return this.triggerField;
            }
            set {
                this.triggerField = value;
            }
        }
    }
}
