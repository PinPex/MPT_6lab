using MPT_6lab;

namespace TestProject1
{
    [TestClass]
    public class TComplexEditorTest
    {
        [TestMethod]
        public void TestMethodIsZero()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();

            // Проверка, равно ли значение number нулю
            bool result = editor.isZero();

            // Ожидаемый результат: true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethodAddSign()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();
            editor.Number = "1+i*1";

            // Изменение знака мнимой части комлексного числа
            string result1 = editor.AddSignImaginary();

            // Ожидаемый результат: "1-i*1"
            Assert.AreEqual("1-i*1", result1);

            // Изменение знака действительной части числа
            string result2 = editor.AddSignReal();

            // Ожидаемый результат: "-1-i*1"
            Assert.AreEqual("-1-i*1", result2);
        }

        [TestMethod]
        public void TestMethodAddDigit()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();

            // Добавление цифр к действительной и мнимой частям числа
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);

            // Ожидаемый результат: "5+i3"
            Assert.AreEqual("5+i*0", result1);
            Assert.AreEqual("5+i*3", result2);

            // Добавление нулей к действительной и мнимой частям числа
            string result3 = editor.AddZeroReal();
            string result4 = editor.AddZeroImaginary();

            // Ожидаемый результат: "50+i30"
            Assert.AreEqual("50+i*3", result3);
            Assert.AreEqual("50+i*30", result4);
        }

        [TestMethod]
        public void TestMethodAddDot()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();

            // Добавление десятичного разделителя к действительной и мнимой частям числа
            string result1 = editor.AddDotReal();
            string result2 = editor.AddDotImaginary();

            // Ожидаемый результат: "0.+" и "0.+i*"
            Assert.AreEqual("0.+i*0", result1);
            Assert.AreEqual("0.+i*0.", result2);
        }
        [TestMethod]
        public void TestMethodBackspace()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();

            // Добавление цифр к действительной и мнимой частям числа
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);

            // Ожидаемый результат: "5+i3"
            Assert.AreEqual("5+i*0", result1);
            Assert.AreEqual("5+i*3", result2);

            // Удаление последней добавленной цифры из действительной и мнимой частей числа
            string result3 = editor.BackspaceReal();
            string result4 = editor.BackspaceImaginary();

            // Ожидаемый результат: "5+i0"
            Assert.AreEqual("0+i*3", result3);
            Assert.AreEqual("0+i*0", result4);
        }

        [TestMethod]
        public void TestMethodClear()
        {
            // Создание экземпляра класса
            ComplexEditor editor = new ComplexEditor();

            // Добавление цифр и десятичных разделителей к действительной и мнимой частям числа
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);
            string result3 = editor.AddDotReal();
            string result4 = editor.AddDotImaginary();

            // Ожидаемый результат: "5.+i3."
            Assert.AreEqual("5.+i*3", result3);
            Assert.AreEqual("5.+i*3.", result4);

            // Сброс значения number и очистка переменных postReal и postImaginary
            string result5 = editor.Clear();

            // Ожидаемый результат: "0+i0"
            Assert.AreEqual("0+i*0", result5);
        }

    }
}