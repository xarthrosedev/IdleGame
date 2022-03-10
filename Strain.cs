
public class Strain
{
    public enum STypes {Indica, Sativa, Hybrid, Hybrid_Indica, Hybrid_Sativa, Unknown};
    public enum SStyle {Flower, Edible, Vape, Other};
    public enum SEffects {};
    public string Name {get; set;} = "";
    public STypes Type {get; set;}
    public string Brand {get; set;} ="";
    public SStyle Style {get; set;}
    public float THCValue {get; set;}
    public float CBDValue {get; set;}
    public float THCAValue {get; set;}
    public float CBDAValue {get; set;}
    public float CannabinoidsValue {get; set;}
    public string Notes {get; set;} = "";
    
}