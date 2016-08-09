
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]

public partial class Controllers
{

    private object[] itemsField;

    private string formIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Controller", typeof(ControllersController))]
    [System.Xml.Serialization.XmlElementAttribute("Expressions", typeof(ControllersExpressions))]
    [System.Xml.Serialization.XmlElementAttribute("SystemVariables", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("ValidationGroups", typeof(ControllersValidationGroups))]
    [System.Xml.Serialization.XmlElementAttribute("ValidationPatterns", typeof(ControllersValidationPatterns))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormID
    {
        get
        {
            return this.formIDField;
        }
        set
        {
            this.formIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersController
{

    private ControllersControllerProperty[] propertiesField;

    private string viewNameField;

    private ControllersControllerField[] fieldsField;

    private ControllersControllerControl[] controlsField;

    private ControllersControllerAssociation[] associationsField;

    private string idField;

    private string instanceIDField;

    private string panelIDField;

    private string mainTableField;

    private string dataSourceIDField;

    private string contextIDField;

    private string contextTypeField;

    private string typeViewField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Property", IsNullable = false)]
    public ControllersControllerProperty[] Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }

    /// <remarks/>
    public string ViewName
    {
        get
        {
            return this.viewNameField;
        }
        set
        {
            this.viewNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable = false)]
    public ControllersControllerField[] Fields
    {
        get
        {
            return this.fieldsField;
        }
        set
        {
            this.fieldsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Control", IsNullable = false)]
    public ControllersControllerControl[] Controls
    {
        get
        {
            return this.controlsField;
        }
        set
        {
            this.controlsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Association", IsNullable = false)]
    public ControllersControllerAssociation[] Associations
    {
        get
        {
            return this.associationsField;
        }
        set
        {
            this.associationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string InstanceID
    {
        get
        {
            return this.instanceIDField;
        }
        set
        {
            this.instanceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PanelID
    {
        get
        {
            return this.panelIDField;
        }
        set
        {
            this.panelIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MainTable
    {
        get
        {
            return this.mainTableField;
        }
        set
        {
            this.mainTableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataSourceID
    {
        get
        {
            return this.dataSourceIDField;
        }
        set
        {
            this.dataSourceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextID
    {
        get
        {
            return this.contextIDField;
        }
        set
        {
            this.contextIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextType
    {
        get
        {
            return this.contextTypeField;
        }
        set
        {
            this.contextTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TypeView
    {
        get
        {
            return this.typeViewField;
        }
        set
        {
            this.typeViewField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerProperty
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerField
{

    private string nameField;

    private string propertyNameField;

    private string propertyTypeField;

    private string fieldTypeField;

    private string idField;

    private string dataSourceIDField;

    private string objectIDField;

    private string objectTypeField;

    private string contextIDField;

    private string contextTypeField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string PropertyName
    {
        get
        {
            return this.propertyNameField;
        }
        set
        {
            this.propertyNameField = value;
        }
    }

    /// <remarks/>
    public string PropertyType
    {
        get
        {
            return this.propertyTypeField;
        }
        set
        {
            this.propertyTypeField = value;
        }
    }

    /// <remarks/>
    public string FieldType
    {
        get
        {
            return this.fieldTypeField;
        }
        set
        {
            this.fieldTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataSourceID
    {
        get
        {
            return this.dataSourceIDField;
        }
        set
        {
            this.dataSourceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ObjectID
    {
        get
        {
            return this.objectIDField;
        }
        set
        {
            this.objectIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ObjectType
    {
        get
        {
            return this.objectTypeField;
        }
        set
        {
            this.objectTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextID
    {
        get
        {
            return this.contextIDField;
        }
        set
        {
            this.contextIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextType
    {
        get
        {
            return this.contextTypeField;
        }
        set
        {
            this.contextTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControl
{

    private ControllersControllerControlProperties propertiesField;

    private string idField;

    private string nameField;

    private string dataTypeField;

    private string fieldIDField;

    private string expressionIDField;

    private string controlTemplateField;

    private string panelIDField;

    /// <remarks/>
    public ControllersControllerControlProperties Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataType
    {
        get
        {
            return this.dataTypeField;
        }
        set
        {
            this.dataTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FieldID
    {
        get
        {
            return this.fieldIDField;
        }
        set
        {
            this.fieldIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExpressionID
    {
        get
        {
            return this.expressionIDField;
        }
        set
        {
            this.expressionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ControlTemplate
    {
        get
        {
            return this.controlTemplateField;
        }
        set
        {
            this.controlTemplateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PanelID
    {
        get
        {
            return this.panelIDField;
        }
        set
        {
            this.panelIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlProperties
{

    private ControllersControllerControlPropertiesProperty[] propertyField;

    private ControllersControllerControlPropertiesStyles stylesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Property")]
    public ControllersControllerControlPropertiesProperty[] Property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStyles Styles
    {
        get
        {
            return this.stylesField;
        }
        set
        {
            this.stylesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesProperty
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStyles
{

    private ControllersControllerControlPropertiesStylesStyle styleField;

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyle Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyle
{

    private ControllersControllerControlPropertiesStylesStyleBorder borderField;

    private string backgroundColorField;

    private ControllersControllerControlPropertiesStylesStylePadding paddingField;

    private string widthField;

    private ControllersControllerControlPropertiesStylesStyleMargin marginField;

    private ControllersControllerControlPropertiesStylesStyleFont fontField;

    private ControllersControllerControlPropertiesStylesStyleFormat formatField;

    private ControllersControllerControlPropertiesStylesStyleText textField;

    private string verticalAlignField;

    private string isDefaultField;

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleBorder Border
    {
        get
        {
            return this.borderField;
        }
        set
        {
            this.borderField = value;
        }
    }

    /// <remarks/>
    public string BackgroundColor
    {
        get
        {
            return this.backgroundColorField;
        }
        set
        {
            this.backgroundColorField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStylePadding Padding
    {
        get
        {
            return this.paddingField;
        }
        set
        {
            this.paddingField = value;
        }
    }

    /// <remarks/>
    public string Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleMargin Margin
    {
        get
        {
            return this.marginField;
        }
        set
        {
            this.marginField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleFont Font
    {
        get
        {
            return this.fontField;
        }
        set
        {
            this.fontField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleFormat Format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleText Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    public string VerticalAlign
    {
        get
        {
            return this.verticalAlignField;
        }
        set
        {
            this.verticalAlignField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IsDefault
    {
        get
        {
            return this.isDefaultField;
        }
        set
        {
            this.isDefaultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleBorder
{

    private ControllersControllerControlPropertiesStylesStyleBorderDefault defaultField;

    /// <remarks/>
    public ControllersControllerControlPropertiesStylesStyleBorderDefault Default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleBorderDefault
{

    private string styleField;

    private string colorField;

    private string widthField;

    /// <remarks/>
    public string Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    public string Color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public string Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStylePadding
{

    private string defaultField;

    private string topField;

    private string bottomField;

    private string leftField;

    private string rightField;

    /// <remarks/>
    public string Default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }

    /// <remarks/>
    public string Top
    {
        get
        {
            return this.topField;
        }
        set
        {
            this.topField = value;
        }
    }

    /// <remarks/>
    public string Bottom
    {
        get
        {
            return this.bottomField;
        }
        set
        {
            this.bottomField = value;
        }
    }

    /// <remarks/>
    public string Left
    {
        get
        {
            return this.leftField;
        }
        set
        {
            this.leftField = value;
        }
    }

    /// <remarks/>
    public string Right
    {
        get
        {
            return this.rightField;
        }
        set
        {
            this.rightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleMargin
{

    private string topField;

    private string bottomField;

    private string leftField;

    private string rightField;

    /// <remarks/>
    public string Top
    {
        get
        {
            return this.topField;
        }
        set
        {
            this.topField = value;
        }
    }

    /// <remarks/>
    public string Bottom
    {
        get
        {
            return this.bottomField;
        }
        set
        {
            this.bottomField = value;
        }
    }

    /// <remarks/>
    public string Left
    {
        get
        {
            return this.leftField;
        }
        set
        {
            this.leftField = value;
        }
    }

    /// <remarks/>
    public string Right
    {
        get
        {
            return this.rightField;
        }
        set
        {
            this.rightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleFont
{

    private string familyField;

    private string sizeField;

    private string styleField;

    private string weightField;

    /// <remarks/>
    public string Family
    {
        get
        {
            return this.familyField;
        }
        set
        {
            this.familyField = value;
        }
    }

    /// <remarks/>
    public string Size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    public string Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    public string Weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleFormat
{

    private string typeField;

    private string cultureField;

    private string currencySymbolField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Culture
    {
        get
        {
            return this.cultureField;
        }
        set
        {
            this.cultureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CurrencySymbol
    {
        get
        {
            return this.currencySymbolField;
        }
        set
        {
            this.currencySymbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerControlPropertiesStylesStyleText
{

    private string alignField;

    /// <remarks/>
    public string Align
    {
        get
        {
            return this.alignField;
        }
        set
        {
            this.alignField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersControllerAssociation
{

    private string associationSOField;

    private string associationMethodField;

    private string valuePropertyField;

    private string displayTemplateField;

    private string controlIDField;

    private string sourceControlIDField;

    private string contextTypeField;

    private string contextIDField;

    private string originalContextIDField;

    private string originalContextTypeField;

    private string originalPropertyField;

    private string parentJoinPropertyField;

    private string childJoinPropertyField;

    private string parentControlField;

    private string parentControlIDField;

    private bool filterPropertyField;

    private bool filterPropertyFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AssociationSO
    {
        get
        {
            return this.associationSOField;
        }
        set
        {
            this.associationSOField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AssociationMethod
    {
        get
        {
            return this.associationMethodField;
        }
        set
        {
            this.associationMethodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValueProperty
    {
        get
        {
            return this.valuePropertyField;
        }
        set
        {
            this.valuePropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DisplayTemplate
    {
        get
        {
            return this.displayTemplateField;
        }
        set
        {
            this.displayTemplateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ControlID
    {
        get
        {
            return this.controlIDField;
        }
        set
        {
            this.controlIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceControlID
    {
        get
        {
            return this.sourceControlIDField;
        }
        set
        {
            this.sourceControlIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextType
    {
        get
        {
            return this.contextTypeField;
        }
        set
        {
            this.contextTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ContextID
    {
        get
        {
            return this.contextIDField;
        }
        set
        {
            this.contextIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OriginalContextID
    {
        get
        {
            return this.originalContextIDField;
        }
        set
        {
            this.originalContextIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OriginalContextType
    {
        get
        {
            return this.originalContextTypeField;
        }
        set
        {
            this.originalContextTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OriginalProperty
    {
        get
        {
            return this.originalPropertyField;
        }
        set
        {
            this.originalPropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParentJoinProperty
    {
        get
        {
            return this.parentJoinPropertyField;
        }
        set
        {
            this.parentJoinPropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ChildJoinProperty
    {
        get
        {
            return this.childJoinPropertyField;
        }
        set
        {
            this.childJoinPropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParentControl
    {
        get
        {
            return this.parentControlField;
        }
        set
        {
            this.parentControlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParentControlID
    {
        get
        {
            return this.parentControlIDField;
        }
        set
        {
            this.parentControlIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool FilterProperty
    {
        get
        {
            return this.filterPropertyField;
        }
        set
        {
            this.filterPropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FilterPropertySpecified
    {
        get
        {
            return this.filterPropertyFieldSpecified;
        }
        set
        {
            this.filterPropertyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressions
{

    private ControllersExpressionsExpression[] expressionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Expression")]
    public ControllersExpressionsExpression[] Expression
    {
        get
        {
            return this.expressionField;
        }
        set
        {
            this.expressionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpression
{

    private ControllersExpressionsExpressionIF ifField;

    private ControllersExpressionsExpressionItem itemField;

    private string idField;

    /// <remarks/>
    public ControllersExpressionsExpressionIF If
    {
        get
        {
            return this.ifField;
        }
        set
        {
            this.ifField = value;
        }
    }

    /// <remarks/>
    public ControllersExpressionsExpressionItem Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionIF
{

    private ControllersExpressionsExpressionIFItem[] equalsField;

    private ControllersExpressionsExpressionIFItem1[] itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public ControllersExpressionsExpressionIFItem[] Equals
    {
        get
        {
            return this.equalsField;
        }
        set
        {
            this.equalsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item")]
    public ControllersExpressionsExpressionIFItem1[] Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionIFItem
{

    private ControllersExpressionsExpressionIFItemSourceValue sourceValueField;

    private string sourceTypeField;

    private string sourceInstanceIDField;

    private string sourceIDField;

    private string dataTypeField;

    /// <remarks/>
    public ControllersExpressionsExpressionIFItemSourceValue SourceValue
    {
        get
        {
            return this.sourceValueField;
        }
        set
        {
            this.sourceValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceType
    {
        get
        {
            return this.sourceTypeField;
        }
        set
        {
            this.sourceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceInstanceID
    {
        get
        {
            return this.sourceInstanceIDField;
        }
        set
        {
            this.sourceInstanceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataType
    {
        get
        {
            return this.dataTypeField;
        }
        set
        {
            this.dataTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionIFItemSourceValue
{

    private string spaceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string space
    {
        get
        {
            return this.spaceField;
        }
        set
        {
            this.spaceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionIFItem1
{

    private ControllersExpressionsExpressionIFItemSourceValue1 sourceValueField;

    private string sourceTypeField;

    private string dataTypeField;

    private string sourceInstanceIDField;

    private string sourceIDField;

    /// <remarks/>
    public ControllersExpressionsExpressionIFItemSourceValue1 SourceValue
    {
        get
        {
            return this.sourceValueField;
        }
        set
        {
            this.sourceValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceType
    {
        get
        {
            return this.sourceTypeField;
        }
        set
        {
            this.sourceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataType
    {
        get
        {
            return this.dataTypeField;
        }
        set
        {
            this.dataTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceInstanceID
    {
        get
        {
            return this.sourceInstanceIDField;
        }
        set
        {
            this.sourceInstanceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionIFItemSourceValue1
{

    private string spaceField;

    private sbyte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string space
    {
        get
        {
            return this.spaceField;
        }
        set
        {
            this.spaceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public sbyte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersExpressionsExpressionItem
{

    private string sourceTypeField;

    private string sourceIDField;

    private string dataTypeField;

    private string sourceInstanceIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceType
    {
        get
        {
            return this.sourceTypeField;
        }
        set
        {
            this.sourceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataType
    {
        get
        {
            return this.dataTypeField;
        }
        set
        {
            this.dataTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SourceInstanceID
    {
        get
        {
            return this.sourceInstanceIDField;
        }
        set
        {
            this.sourceInstanceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersValidationGroups
{

    private ControllersValidationGroupsValidationGroup[] validationGroupField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ValidationGroup")]
    public ControllersValidationGroupsValidationGroup[] ValidationGroup
    {
        get
        {
            return this.validationGroupField;
        }
        set
        {
            this.validationGroupField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersValidationGroupsValidationGroup
{

    private ControllersValidationGroupsValidationGroupValidationGroupControl[] validationGroupControlsField;

    private string idField;

    private string nameField;

    private string messageField;

    private string instanceIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ValidationGroupControl", IsNullable = false)]
    public ControllersValidationGroupsValidationGroupValidationGroupControl[] ValidationGroupControls
    {
        get
        {
            return this.validationGroupControlsField;
        }
        set
        {
            this.validationGroupControlsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string InstanceID
    {
        get
        {
            return this.instanceIDField;
        }
        set
        {
            this.instanceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersValidationGroupsValidationGroupValidationGroupControl
{

    private string idField;

    private string controlIDField;

    private bool isRequiredField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ControlID
    {
        get
        {
            return this.controlIDField;
        }
        set
        {
            this.controlIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IsRequired
    {
        get
        {
            return this.isRequiredField;
        }
        set
        {
            this.isRequiredField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersValidationPatterns
{

    private ControllersValidationPatternsValidationPattern validationPatternField;

    /// <remarks/>
    public ControllersValidationPatternsValidationPattern ValidationPattern
    {
        get
        {
            return this.validationPatternField;
        }
        set
        {
            this.validationPatternField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ControllersValidationPatternsValidationPattern
{

    private string idField;

    private string nameField;

    private string messageField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

