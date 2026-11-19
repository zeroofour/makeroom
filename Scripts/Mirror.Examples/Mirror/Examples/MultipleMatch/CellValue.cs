using System;

namespace Mirror.Examples.MultipleMatch;

[Flags]
public enum CellValue : ushort
{
	None = 0,
	A1 = 1,
	B1 = 2,
	C1 = 4,
	A2 = 8,
	B2 = 0x10,
	C2 = 0x20,
	A3 = 0x40,
	B3 = 0x80,
	C3 = 0x100,
	TopRow = A1 | B1 | C1,
	MidRow = A2 | B2 | C2,
	BotRow = A3 | B3 | C3,
	LeftCol = A1 | A2 | A3,
	MidCol = B1 | B2 | B3,
	RightCol = C1 | C2 | C3,
	Diag1 = A1 | B2 | C3,
	Diag2 = C1 | B2 | A3,
	Full = TopRow | MidRow | BotRow
}
