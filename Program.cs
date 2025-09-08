// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

internal class AClass {} // correctly not flagged
public interface AnInterface { // correctly not flagged
	/*public*/ int Number { get; } // correctly not flagged
	/*public*/ string String { get; } // correctly not flagged
	public struct AStruct {} // erroneously flagged
}
