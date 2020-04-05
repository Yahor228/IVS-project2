using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests


// Егор, Вика
// В этом файле находится скелет для создания вами тестов
// Я уже создал тест для проверки того, как работают нажатия на кнопки '0' - '9'
// Вы можете смотреть на его структуру, чтобы понять, как он должен работать
// Здесь кратко объясняю что происходит
// **************************************
// ivs_project2.Form1 testedForm = new ivs_project2.Form1();
// Так мы создаем новый объект testedForm. По сути это и является нашим калькуляторм, далее все операции проводятся над ним
// 
// У него есть свойство testedForm.label_result.Text, в нем содержиться текст который на данный момент отображается на калькуляторе
// Как вы понимаете, чтобы проверить что происходит, результаты вычислений и тд, нужно обращаться к этому свойству
// Изначально свойство testedForm.label_result.Text равно "...", это типа базовая надпись, которая отображается
// 
// После нажатия на какую-лио кнопку, текст меняется, и вы должны это протестировать
// Например вы просимулировали нажатие на кнопку '1', и значение testedForm.label_result.Text уже должно быть не "..." а "1"
// потом нажали на кнопку '2' и значение testedForm.label_result.Text уже должно быть "12" и тд
// Так вы должны эмулировть нажатие на кнопки и проверять то, что сейчас отображается
//
// Эмулировать нажатие на кнопки просто - нужно написать подобную конструкцию
// testedForm.button_1_Click(testedForm, e);
// Где button_1_Click - это нужная команда:
//
// button_n_Click - кнопки цифр n 0-9
//
// button_remove_Click - кнопка "назад" '<'
//
// button_delete_Click - кнопка "удалить"
//
// button_dot_Click - кнопка "точки"  ','
//
// button_plus_Click - кнопка "плюс"  '+'
//
// button_minus_Click - кнопка "минус"  '-'
//
// button_multiply_Click - кнопка "умножить"  '*'
//
// button_divide_Click - кнопка "разделить"  '.'
//
// button_equal_Click - кнопка "равно"  '='
//
// button_degree_Click - кнопка "возведение в степень"  '^'
//
// button_radical_Click - кнопка "извлечение корня"  '√'
//
// button_percent_Click - кнопка "подсчет процента"  '%'
//
// button_factorial_Click - кнопка "факториал"  '!'
//
//
// Тесты запускаются если сверху нажать на "Тест" -> "Запуск всех тестов"
// **************************************

{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]

        // Tests of basic inputting
        public void EnteringTests()
        {
            // Creating of new object for testing
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();
            
            // Controlling if current text on the panel is equal to '...'
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            // Emulation of clicking on buttons '1' and '2'
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("12"));

            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("1"));

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("12345"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_6_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_8_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("67890"));

            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("678"));


            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

        }

        [TestMethod]

        // Tests of plus
        // Created by Yahor Senichak
        public void PlusTests()
        {
            // Write tests of plus here
        }

        [TestMethod]

        // Tests of minus
        // Created by Viktoryia Tomason
        public void MinusTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of multiply
        // Created by Yahor Senichak
        public void MultiplyTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of divide
        // Created by Viktoryia Tomason
        public void DivideTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of equal
        // Created by Yahor Senichak and Viktoryia Tomason
        public void EqualTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of degree
        // Created by Yahor Senichak
        public void DegreeTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of radical
        // Created by Viktoryia Tomason
        public void RadicalTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of percent
        // Created by Viktoryia Tomason
        public void PercentTests()
        {
            // Write tests here
        }

        [TestMethod]

        // Tests of factorial
        // Created by Yahor Senichak
        public void FactorialTests()
        {
            // Write tests here
        }
    }
}
