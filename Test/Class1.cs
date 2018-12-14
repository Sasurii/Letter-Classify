using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Letter_Classify;

namespace Classifier.Test
{
    public class ClassifierTest
    {
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Standardbrief"
        ///</summary>
        void Classifier_Test_Standardbrief()
        { 
            //Arrange 
            int length = 140;
            int width = 90;
            int height = 5;
            int weight = 20;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Standardbrief");
        }
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Kompaktbrief"
        ///</summary>
        void Classifier_Test_Kompaktbrief()
        {
            //Arrange
            int length = 200;
            int width = 100;
            int height = 10;
            int weight = 40;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Kompaktbrief");
        }
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Großbrief"
        ///</summary>
        void Classifier_Test_Großbrief()
        {
            //Arrange
            int length = 250;
            int width = 250;
            int height = 15;
            int weight = 350;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Großbrief");
        }
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Maxibrief"
        ///</summary>
        void Classifier_Test_Maxibrief()
        {
            //Arrange
            int length = 140;
            int width = 100;
            int height = 25;
            int weight = 200;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Maxibrief");
        }
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Maxibrief Plus"
        ///</summary>
        void Classifier_Test_Maxibrief_Plus()
        {
            //Arrange
            int length = 600;
            int width = 300;
            int height = 150;
            int weight = 2000;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Maxibrief Plus");
        }
        [Fact]
        ///<summary>
        ///Classify Letters based on entries, output must be "Maxibrief Plus"
        ///</summary>
        void Classifier_Test_Maxibrief_Plus2()
        {
            //Arrange
            int length = 300;
            int width = 300;
            int height = 300;
            int weight = 1800;

            //Act
            string ergebnis = Program.Classifier(length, width, height, weight);

            //Assert
            ergebnis.Should().Be("Maxibrief Plus");
        }
    }
}
