﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocumentFormat.OpenXml.Framework {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DocumentFormat.OpenXml.Framework.ExceptionMessages", typeof(ExceptionMessages).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The part cannot be added here..
        /// </summary>
        public static string AddedPartIsNotAllowed {
            get {
                return ResourceManager.GetString("AddedPartIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot change the document type..
        /// </summary>
        public static string CannotChangeDocumentType {
            get {
                return ResourceManager.GetString("CannotChangeDocumentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot change the document type. The document may be corrupt..
        /// </summary>
        public static string CannotChangeDocumentTypeSerious {
            get {
                return ResourceManager.GetString("CannotChangeDocumentTypeSerious", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The element does not allow the specified attribute..
        /// </summary>
        public static string CannotFindAttribute {
            get {
                return ResourceManager.GetString("CannotFindAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot load the root element from the part. The part contains invalid data..
        /// </summary>
        public static string CannotLoadRootElement {
            get {
                return ResourceManager.GetString("CannotLoadRootElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot reload the DOM tree since this element is not associated with an OpenXmlPart..
        /// </summary>
        public static string CannotReloadDomTreeWithoutAssociatedPart {
            get {
                return ResourceManager.GetString("CannotReloadDomTreeWithoutAssociatedPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot save DOM tree since this element is not associated with an OpenXmlPart..
        /// </summary>
        public static string CannotSaveDomTreeWithoutAssociatedPart {
            get {
                return ResourceManager.GetString("CannotSaveDomTreeWithoutAssociatedPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set XML namespace declaration here. Use AddNamespaceDeclaration method instead..
        /// </summary>
        public static string CannotSetAttribute {
            get {
                return ResourceManager.GetString("CannotSetAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The OpenXmlValidator cannot validate against AlternateContent, AlternateContentChoice and AlternateContentFallback..
        /// </summary>
        public static string CannotValidateAcbElement {
            get {
                return ResourceManager.GetString("CannotValidateAcbElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The OpenXmlValidator cannot validate against OpenXmlMiscNode..
        /// </summary>
        public static string CannotValidateMiscNode {
            get {
                return ResourceManager.GetString("CannotValidateMiscNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The OpenXmlValidator cannot validate against OpenXmlUnknownElement..
        /// </summary>
        public static string CannotValidateUnknownElement {
            get {
                return ResourceManager.GetString("CannotValidateUnknownElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A circular reference has been detected..
        /// </summary>
        public static string CycleReference {
            get {
                return ResourceManager.GetString("CycleReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified DataPart is referenced by other parts..
        /// </summary>
        public static string DataPartIsInUse {
            get {
                return ResourceManager.GetString("DataPartIsInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified DataPartReferenceRelationship is not allowed with this parent..
        /// </summary>
        public static string DataPartReferenceIsNotAllowed {
            get {
                return ResourceManager.GetString("DataPartReferenceIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You should not validate document preprocessed based on FileFormatVersions.{0} against FileFormatVersions.{1} constraints. The preprocessing file format version is set in OpenSettings. Also check the file format version setting in the OpenXmlValidator..
        /// </summary>
        public static string DocumentFileFormatVersionMismatch {
            get {
                return ResourceManager.GetString("DocumentFileFormatVersionMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The document has exceeded the size limit. Its type cannot be changed..
        /// </summary>
        public static string DocumentTooBig {
            get {
                return ResourceManager.GetString("DocumentTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The prefix &quot;{0}&quot; is already defined in current node..
        /// </summary>
        public static string DuplicatedPrefix {
            get {
                return ResourceManager.GetString("DuplicatedPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified oldChild is not a child of this element..
        /// </summary>
        public static string ElementIsNotChild {
            get {
                return ResourceManager.GetString("ElementIsNotChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2007 rules. The passed in element is not defined in Microsoft Office 2007..
        /// </summary>
        public static string ElementIsNotInOffice2007 {
            get {
                return ResourceManager.GetString("ElementIsNotInOffice2007", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2010 rules. The passed in element is not defined in Microsoft Office 2010..
        /// </summary>
        public static string ElementIsNotInOffice2010 {
            get {
                return ResourceManager.GetString("ElementIsNotInOffice2010", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2013 rules. The passed in element is not defined in Microsoft Office 2013..
        /// </summary>
        public static string ElementIsNotInOffice2013 {
            get {
                return ResourceManager.GetString("ElementIsNotInOffice2013", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot insert the OpenXmlElement &quot;newChild&quot; because it is part of a tree. .
        /// </summary>
        public static string ElementIsPartOfTree {
            get {
                return ResourceManager.GetString("ElementIsPartOfTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Empty collection..
        /// </summary>
        public static string EmptyCollection {
            get {
                return ResourceManager.GetString("EmptyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The contentType parameter has incorrect value..
        /// </summary>
        public static string ErrorContentType {
            get {
                return ResourceManager.GetString("ErrorContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An ExtendedPart was encountered with a relationship type that starts with &quot;http://schemas.openxmlformats.org&quot;. Expected a defined part instead based on the relationship type..
        /// </summary>
        public static string ExtendedPartIsOpenXmlPart {
            get {
                return ResourceManager.GetString("ExtendedPartIsOpenXmlPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to ExtendedPart must be added by AddExtendedPart( )..
        /// </summary>
        public static string ExtendedPartNotAllowed {
            get {
                return ResourceManager.GetString("ExtendedPartNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified ExternalRelationship is not referenced by this part..
        /// </summary>
        public static string ExternalRelationshipIsNotReferenced {
            get {
                return ResourceManager.GetString("ExternalRelationshipIsNotReferenced", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified FileFormatVersions parameter has an invalid value: {0}.
        /// </summary>
        public static string FileFormatNotSupported {
            get {
                return ResourceManager.GetString("FileFormatNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The root XML element &quot;{0}&quot; in the part is incorrect. The expected root XML element is: &quot;{1}&quot;..
        /// </summary>
        public static string Fmt_PartRootIsInvalid {
            get {
                return ResourceManager.GetString("Fmt_PartRootIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified DataPart is not in this document..
        /// </summary>
        public static string ForeignDataPart {
            get {
                return ResourceManager.GetString("ForeignDataPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified MediaDataPart is not in this document..
        /// </summary>
        public static string ForeignMediaDataPart {
            get {
                return ResourceManager.GetString("ForeignMediaDataPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified OpenXmlPart is not referenced by this part..
        /// </summary>
        public static string ForeignOpenXmlPart {
            get {
                return ResourceManager.GetString("ForeignOpenXmlPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified ExternalRelationship is not referenced by this part..
        /// </summary>
        public static string HyperlinkRelationshipIsNotReferenced {
            get {
                return ResourceManager.GetString("HyperlinkRelationshipIsNotReferenced", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Error in implicit conversion. Cannot convert null object..
        /// </summary>
        public static string ImplicitConversionExceptionOnNull {
            get {
                return ResourceManager.GetString("ImplicitConversionExceptionOnNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This OpenXmlElement&apos;s InnerXml cannot be set..
        /// </summary>
        public static string InnerXmlCannotBeSet {
            get {
                return ResourceManager.GetString("InnerXmlCannotBeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The content type of the part is invalid. The expected content type is: {0}..
        /// </summary>
        public static string InvalidContentTypePart {
            get {
                return ResourceManager.GetString("InvalidContentTypePart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified value is not valid according to the specified enum type..
        /// </summary>
        public static string InvalidEnumValue {
            get {
                return ResourceManager.GetString("InvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set the MainPartContentType property to this value because it is not valid for this type of document..
        /// </summary>
        public static string InvalidMainPartContentType {
            get {
                return ResourceManager.GetString("InvalidMainPartContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified MarkupCompatibilityProcessSettings.TargetFileFormatVersions is invalid to process the extensibility markup..
        /// </summary>
        public static string InvalidMCMode {
            get {
                return ResourceManager.GetString("InvalidMCMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The XML has invalid content and cannot be constructed as an element..
        /// </summary>
        public static string InvalidOuterXml {
            get {
                return ResourceManager.GetString("InvalidOuterXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The XML has invalid content and cannot be constructed as an element..
        /// </summary>
        public static string InvalidOuterXmlForMiscNode {
            get {
                return ResourceManager.GetString("InvalidOuterXmlForMiscNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified package is not valid..
        /// </summary>
        public static string InvalidPackageType {
            get {
                return ResourceManager.GetString("InvalidPackageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The document cannot be opened because there is an invalid part with an unexpected content type. 
        ///[Part Uri={0}], 
        ///[Content Type={1}], 
        ///[Expected Content Type={2}]..
        /// </summary>
        public static string InvalidPartContentType {
            get {
                return ResourceManager.GetString("InvalidPartContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid Hyperlink: Malformed URI is embedded as a hyperlink in the document..
        /// </summary>
        public static string InvalidUriFormat {
            get {
                return ResourceManager.GetString("InvalidUriFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Text string can only be written out in OpenXmlLeafTextElement..
        /// </summary>
        public static string InvalidWriteStringCall {
            get {
                return ResourceManager.GetString("InvalidWriteStringCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An invalid XML ID string.
        /// </summary>
        public static string InvalidXmlIDStringException {
            get {
                return ResourceManager.GetString("InvalidXmlIDStringException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This OpenXmlLeafElement&apos;s InnerXml can only be set to null or to an empty string..
        /// </summary>
        public static string LeafElementInnerXmlCannotBeSet {
            get {
                return ResourceManager.GetString("LeafElementInnerXmlCannotBeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to LocalName is null or empty..
        /// </summary>
        public static string LocalNameIsNull {
            get {
                return ResourceManager.GetString("LocalNameIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The part cannot be added to this package because its content type is not allowed in this type of document..
        /// </summary>
        public static string MainPartIsDifferent {
            get {
                return ResourceManager.GetString("MainPartIsDifferent", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An Audio / Video part shall not have implicit or explicit relationships to other parts defined by Open XML Standard..
        /// </summary>
        public static string MediaDataPartShouldNotReferenceOtherParts {
            get {
                return ResourceManager.GetString("MediaDataPartShouldNotReferenceOtherParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There are more than one relationship references that target the specified part..
        /// </summary>
        public static string MultipleRelationshipsToSamePart {
            get {
                return ResourceManager.GetString("MultipleRelationshipsToSamePart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified package is invalid. The main part is missing..
        /// </summary>
        public static string NoMainPart {
            get {
                return ResourceManager.GetString("NoMainPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Non-composite elements do not have child elements..
        /// </summary>
        public static string NonCompositeNoChild {
            get {
                return ResourceManager.GetString("NonCompositeNoChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The method or operation has not been implemented..
        /// </summary>
        public static string NonImplemented {
            get {
                return ResourceManager.GetString("NonImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No external relationship with the specified ID was found..
        /// </summary>
        public static string NoSpecifiedExternalRelationship {
            get {
                return ResourceManager.GetString("NoSpecifiedExternalRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No hyperlink relationship with the specified ID was found..
        /// </summary>
        public static string NoSpecifiedHyperlinkRelationship {
            get {
                return ResourceManager.GetString("NoSpecifiedHyperlinkRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No ReferenceRelationship with the specified ID was found..
        /// </summary>
        public static string NoSpecifiedReferenceRelationship {
            get {
                return ResourceManager.GetString("NoSpecifiedReferenceRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Current Markup Compatibility mode does not understand namespace prefix &quot;{0}&quot;..
        /// </summary>
        public static string NsNotUnderStand {
            get {
                return ResourceManager.GetString("NsNotUnderStand", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Only one instance of the type is allowed for this parent..
        /// </summary>
        public static string OnlyOnePartAllowed {
            get {
                return ResourceManager.GetString("OnlyOnePartAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This operation requires that the document be opened with ReadWrite (or Write) access..
        /// </summary>
        public static string PackageAccessModeIsReadonly {
            get {
                return ResourceManager.GetString("PackageAccessModeIsReadonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This operation requires that the package be opened with Read access..
        /// </summary>
        public static string PackageMustCanBeRead {
            get {
                return ResourceManager.GetString("PackageMustCanBeRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Arguments openXmlPackage and its parent cannot be null at same time..
        /// </summary>
        public static string PackageRelatedArgumentNullException {
            get {
                return ResourceManager.GetString("PackageRelatedArgumentNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The parent of this element is null..
        /// </summary>
        public static string ParentIsNull {
            get {
                return ResourceManager.GetString("ParentIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified part is already referenced as a target part by a relationship with a different ID..
        /// </summary>
        public static string PartExistsWithDifferentRelationshipId {
            get {
                return ResourceManager.GetString("PartExistsWithDifferentRelationshipId", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The part has been destroyed..
        /// </summary>
        public static string PartIsDestroyed {
            get {
                return ResourceManager.GetString("PartIsDestroyed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The XML content is empty..
        /// </summary>
        public static string PartIsEmpty {
            get {
                return ResourceManager.GetString("PartIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified part is not allowed with this parent..
        /// </summary>
        public static string PartIsNotAllowed {
            get {
                return ResourceManager.GetString("PartIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2007 rules. The passed in part is not defined in Microsoft Office 2007..
        /// </summary>
        public static string PartIsNotInOffice2007 {
            get {
                return ResourceManager.GetString("PartIsNotInOffice2007", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2010 rules. The passed in part is not defined in Microsoft Office 2010..
        /// </summary>
        public static string PartIsNotInOffice2010 {
            get {
                return ResourceManager.GetString("PartIsNotInOffice2010", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The validator is set to validate content based on Microsoft Office 2013 rules. The passed in part is not defined in Microsoft Office 2013..
        /// </summary>
        public static string PartIsNotInOffice2013 {
            get {
                return ResourceManager.GetString("PartIsNotInOffice2013", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A relationship can only be created between two parts in a package..
        /// </summary>
        public static string PartNotInSamePackage {
            get {
                return ResourceManager.GetString("PartNotInSamePackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The OpenXmlPart is not a valid part in the specified FileFormat version..
        /// </summary>
        public static string PartNotInVersion {
            get {
                return ResourceManager.GetString("PartNotInVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set the given root element to this part. The given part root element has already been associated with another OpenXmlPart..
        /// </summary>
        public static string PartRootAlreadyHasAssociation {
            get {
                return ResourceManager.GetString("PartRootAlreadyHasAssociation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The XML content is unknown. Cannot create an OpenXmlReader on that content..
        /// </summary>
        public static string PartUnknown {
            get {
                return ResourceManager.GetString("PartUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} property cannot be set when the {1} property is not null..
        /// </summary>
        public static string PropertyMutualExclusive {
            get {
                return ResourceManager.GetString("PropertyMutualExclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The reader is now positioned at the end element tag..
        /// </summary>
        public static string ReaderInEndState {
            get {
                return ResourceManager.GetString("ReaderInEndState", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The reader is now positioned at EOF..
        /// </summary>
        public static string ReaderInEofState {
            get {
                return ResourceManager.GetString("ReaderInEofState", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The reader is now positioned before the first element. Call OpenXmlReader.Read() before this operation..
        /// </summary>
        public static string ReaderInNullState {
            get {
                return ResourceManager.GetString("ReaderInNullState", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified ReferenceRelationship is not referenced by this part..
        /// </summary>
        public static string ReferenceRelationshipIsNotReferenced {
            get {
                return ResourceManager.GetString("ReferenceRelationshipIsNotReferenced", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Id conflicts with the Id of an existing relationship..
        /// </summary>
        public static string RelationshipIdConflict {
            get {
                return ResourceManager.GetString("RelationshipIdConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A required part is missing. The class name is stored in the PartClassName property..
        /// </summary>
        public static string RequiredPartDoNotExist {
            get {
                return ResourceManager.GetString("RequiredPartDoNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A shared part is referenced by multiple source parts with a different relationship type..
        /// </summary>
        public static string SamePartWithDifferentRelationshipType {
            get {
                return ResourceManager.GetString("SamePartWithDifferentRelationshipType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The stream was not opened for writing..
        /// </summary>
        public static string StreamAccessModeShouldBeWrite {
            get {
                return ResourceManager.GetString("StreamAccessModeShouldBeWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to ISO 29500 Strict formatted document can&apos;t be opened while edit operation is enabled..
        /// </summary>
        public static string StrictReadOnly {
            get {
                return ResourceManager.GetString("StrictReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The string argument cannot be empty..
        /// </summary>
        public static string StringArgumentEmptyException {
            get {
                return ResourceManager.GetString("StringArgumentEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified string is empty..
        /// </summary>
        public static string StringIsEmpty {
            get {
                return ResourceManager.GetString("StringIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The text value is not a valid enumeration value..
        /// </summary>
        public static string TextIsInvalidEnumValue {
            get {
                return ResourceManager.GetString("TextIsInvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The text value is invalid. It can be only &apos;true&apos;, &apos;false&apos;, &apos;on&apos;, &apos;off&apos;, &apos;0&apos;, &apos;1&apos;..
        /// </summary>
        public static string TextIsInvalidOnOffValue {
            get {
                return ResourceManager.GetString("TextIsInvalidOnOffValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The text value is invalid. It can be only &apos;true&apos;, &apos;false&apos;, &apos;t&apos;, &apos;f&apos;, &apos;&apos;..
        /// </summary>
        public static string TextIsInvalidTrueFalseBlankValue {
            get {
                return ResourceManager.GetString("TextIsInvalidTrueFalseBlankValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The text value is invalid. It can be only &apos;true&apos;, &apos;false&apos;, &apos;t&apos;, &apos;f&apos;..
        /// </summary>
        public static string TextIsInvalidTrueFalseValue {
            get {
                return ResourceManager.GetString("TextIsInvalidTrueFalseValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There is invalid extensibility markup in &quot;{0}&quot;..
        /// </summary>
        public static string UnknowMCContent {
            get {
                return ResourceManager.GetString("UnknowMCContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified package is unknown..
        /// </summary>
        public static string UnknownPackage {
            get {
                return ResourceManager.GetString("UnknownPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Do not add hyperlink relationships through the AddExternalRelationship() method. Use AddHyperlinkRelationship() instead..
        /// </summary>
        public static string UseAddHyperlinkRelationship {
            get {
                return ResourceManager.GetString("UseAddHyperlinkRelationship", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The OpenXmlPackage.Validate method found an error in the document..
        /// </summary>
        public static string ValidationException {
            get {
                return ResourceManager.GetString("ValidationException", resourceCulture);
            }
        }
    }
}
