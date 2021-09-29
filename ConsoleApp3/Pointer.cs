namespace ConsoleApp3
{
    /// <summary>
    /// Класс точки
    /// </summary>
    public class Pointer
    {
        /// <summary>
        /// Поля: Точка A, Точка B
        /// </summary>
        private double _apoint, _bpoint;
        
        /// <summary>
        /// Поле наименования фигуры
        /// </summary>
        private string _nameFigure;
        
        /// <summary>
        /// Свойство указателя х
        /// </summary>
        public double PointerA { get => _apoint; }
        
        /// <summary>
        /// Свойство указателя y
        /// </summary>
        public double PointerB { get => _bpoint; }
        
        /// <summary>
        /// Свойство наименования фигуры
        /// </summary>
        public  string NameFigure { get => _nameFigure; }

        /// <summary>
        /// Конструктор указателя
        /// </summary>
        /// <param name="xpoint">указатель по x</param>
        /// <param name="ypoint">указатель по y</param>
        /// <param name="nameFigure">Наименование фигуры</param>
        public Pointer(double apoint, double bpoint, string nameFigure)
        {
            this._apoint = apoint;
            this._bpoint = bpoint;
            this._nameFigure = nameFigure;
        }
    }
}