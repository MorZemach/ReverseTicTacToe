namespace ReverseTicTacToe.Logic
{
    public struct BoardCell
    {
        public byte m_Row;
        public byte m_Col;

        public BoardCell(byte i_Row = 0, byte i_Col = 0)
        {
            m_Row = i_Row;
            m_Col = i_Col;
        }

        public byte Row
        {
            get { return m_Row; }
            set { m_Row = value; }
        }

        public byte Col
        {
            get { return m_Col; }
            set { m_Col = value; }
        }
    }
}
