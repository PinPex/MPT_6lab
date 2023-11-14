using MPT_6lab;

namespace TestProject1
{
    [TestClass]
    public class TComplexEditorTest
    {
        [TestMethod]
        public void TestMethodIsZero()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();

            // ��������, ����� �� �������� number ����
            bool result = editor.isZero();

            // ��������� ���������: true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethodAddSign()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();
            editor.Number = "1+i*1";

            // ��������� ����� ������ ����� ����������� �����
            string result1 = editor.AddSignImaginary();

            // ��������� ���������: "1-i*1"
            Assert.AreEqual("1-i*1", result1);

            // ��������� ����� �������������� ����� �����
            string result2 = editor.AddSignReal();

            // ��������� ���������: "-1-i*1"
            Assert.AreEqual("-1-i*1", result2);
        }

        [TestMethod]
        public void TestMethodAddDigit()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();

            // ���������� ���� � �������������� � ������ ������ �����
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);

            // ��������� ���������: "5+i3"
            Assert.AreEqual("5+i*0", result1);
            Assert.AreEqual("5+i*3", result2);

            // ���������� ����� � �������������� � ������ ������ �����
            string result3 = editor.AddZeroReal();
            string result4 = editor.AddZeroImaginary();

            // ��������� ���������: "50+i30"
            Assert.AreEqual("50+i*3", result3);
            Assert.AreEqual("50+i*30", result4);
        }

        [TestMethod]
        public void TestMethodAddDot()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();

            // ���������� ����������� ����������� � �������������� � ������ ������ �����
            string result1 = editor.AddDotReal();
            string result2 = editor.AddDotImaginary();

            // ��������� ���������: "0.+" � "0.+i*"
            Assert.AreEqual("0.+i*0", result1);
            Assert.AreEqual("0.+i*0.", result2);
        }
        [TestMethod]
        public void TestMethodBackspace()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();

            // ���������� ���� � �������������� � ������ ������ �����
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);

            // ��������� ���������: "5+i3"
            Assert.AreEqual("5+i*0", result1);
            Assert.AreEqual("5+i*3", result2);

            // �������� ��������� ����������� ����� �� �������������� � ������ ������ �����
            string result3 = editor.BackspaceReal();
            string result4 = editor.BackspaceImaginary();

            // ��������� ���������: "5+i0"
            Assert.AreEqual("0+i*3", result3);
            Assert.AreEqual("0+i*0", result4);
        }

        [TestMethod]
        public void TestMethodClear()
        {
            // �������� ���������� ������
            ComplexEditor editor = new ComplexEditor();

            // ���������� ���� � ���������� ������������ � �������������� � ������ ������ �����
            string result1 = editor.AddDigitReal(5);
            string result2 = editor.AddDigitImaginary(3);
            string result3 = editor.AddDotReal();
            string result4 = editor.AddDotImaginary();

            // ��������� ���������: "5.+i3."
            Assert.AreEqual("5.+i*3", result3);
            Assert.AreEqual("5.+i*3.", result4);

            // ����� �������� number � ������� ���������� postReal � postImaginary
            string result5 = editor.Clear();

            // ��������� ���������: "0+i0"
            Assert.AreEqual("0+i*0", result5);
        }

    }
}