using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivaMachine_Offical;

namespace TriviaMachine_Offical
{ // THIS IS AN AUXILERLY FUNCTION. NO ACTUAL PROGRAMMING SHOULD BE DONE HERE!
    public class WritingNewTriviaToFile
    {
        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";

        public void WriteTriviaToFile()
        {
            // Use this function to write the Trivia to the File for the First Time.
            // Then this file can be deleted.

            // This is the list of current trivia:
            List<TriviaQuestion> ListofTriviaToWrite = new List<TriviaQuestion>();
            List<string> TriviaQuestionAnswerOptions = new List<string>();


            TriviaQuestionAnswerOptions.Add("Elliptical.");
            TriviaQuestionAnswerOptions.Add("Spiral.");
            TriviaQuestionAnswerOptions.Add("Irregular.");
            TriviaQuestionAnswerOptions.Add("Cubical.");
            TriviaQuestion TriviaQuestionToAdd = new TriviaQuestion("Which of the following galaxy types is most ubiquitous?", TriviaQuestionAnswerOptions, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd);


            List<string> TriviaQuestionAnswerOptions2 = new List<string>();
            TriviaQuestionAnswerOptions2.Add("13.7 billion years.");
            TriviaQuestionAnswerOptions2.Add("8.3 billion years");
            TriviaQuestionAnswerOptions2.Add("13.7 million years");
            TriviaQuestionAnswerOptions2.Add("8.3 million years");
            TriviaQuestion TriviaQuestionToAdd2 = new TriviaQuestion("What is the approximate age of the universe?", TriviaQuestionAnswerOptions2, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd2);


            List<string> TriviaQuestionAnswerOptions3 = new List<string>();
            TriviaQuestionAnswerOptions3.Add("Red Dwarf.");
            TriviaQuestionAnswerOptions3.Add("Brown Dwarf.");
            TriviaQuestionAnswerOptions3.Add("Red Giant.");
            TriviaQuestionAnswerOptions3.Add("Neutron Star.");
            TriviaQuestion TriviaQuestionToAdd3 = new TriviaQuestion("What is the most common type of star in the Milky Way?", TriviaQuestionAnswerOptions3, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd3);

            List<string> TriviaQuestionAnswerOptions4 = new List<string>();
            TriviaQuestionAnswerOptions4.Add("A Black Hole.");
            TriviaQuestionAnswerOptions4.Add("A Wormhole.");
            TriviaQuestionAnswerOptions4.Add("Our Solar System.");
            TriviaQuestionAnswerOptions4.Add("A Supernova.");
            TriviaQuestion TriviaQuestionToAdd4 = new TriviaQuestion("What is at the center of the Milky Way", TriviaQuestionAnswerOptions4, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd4);


            List<string> TriviaQuestionAnswerOptions5 = new List<string>();
            TriviaQuestionAnswerOptions5.Add("Proxima Centauri.");
            TriviaQuestionAnswerOptions5.Add("Epsilon Eridani.");
            TriviaQuestionAnswerOptions5.Add("Alpha Centauri.");
            TriviaQuestionAnswerOptions5.Add("There are no other stars in the Milky Way.");
            TriviaQuestion TriviaQuestionToAdd5 = new TriviaQuestion("Outside of the Sun, what is the closest star to Earth?", TriviaQuestionAnswerOptions5, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd5);


            List<string> TriviaQuestionAnswerOptions6 = new List<string>();
            TriviaQuestionAnswerOptions6.Add("Past Pluto.");
            TriviaQuestionAnswerOptions6.Add("Between Mars and Jupiter.");
            TriviaQuestionAnswerOptions6.Add("On Jupiter.");
            TriviaQuestionAnswerOptions6.Add("Around the Sun.");
            TriviaQuestion TriviaQuestionToAdd6 = new TriviaQuestion("Where is the Oort Cloud located?", TriviaQuestionAnswerOptions6, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd6);


            List<string> TriviaQuestionAnswerOptions7 = new List<string>();
            TriviaQuestionAnswerOptions7.Add("A lightyear is not a measure of time.");
            TriviaQuestionAnswerOptions7.Add("1 million years.");
            TriviaQuestionAnswerOptions7.Add("13.7 billion years.");
            TriviaQuestionAnswerOptions7.Add("2.5 nanoseconds.");
            TriviaQuestion TriviaQuestionToAdd7 = new TriviaQuestion("How long is a lightyear?", TriviaQuestionAnswerOptions7, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd7);


            List<string> TriviaQuestionAnswerOptions8 = new List<string>();
            TriviaQuestionAnswerOptions8.Add("5.9 trillion miles.");
            TriviaQuestionAnswerOptions8.Add("21.3 billion miles.");
            TriviaQuestionAnswerOptions8.Add("93.7 million miles.");
            TriviaQuestionAnswerOptions8.Add("A lightyear is not a measure of distance.");
            TriviaQuestion TriviaQuestionToAdd8 = new TriviaQuestion("Approximately how many miles are in a lightyear?", TriviaQuestionAnswerOptions8, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd8);


            List<string> TriviaQuestionAnswerOptions9 = new List<string>();
            TriviaQuestionAnswerOptions9.Add("Dark Matter.");
            TriviaQuestionAnswerOptions9.Add("Hydrogen.");
            TriviaQuestionAnswerOptions9.Add("Electromagnetic Radiation.");
            TriviaQuestionAnswerOptions9.Add("Empty Space.");
            TriviaQuestion TriviaQuestionToAdd9 = new TriviaQuestion("What accounts for approximately 85% of matter in the universe?", TriviaQuestionAnswerOptions9, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd9);

            List<string> TriviaQuestionAnswerOptions10 = new List<string>();
            TriviaQuestionAnswerOptions10.Add("The Boomerang Nebula.");
            TriviaQuestionAnswerOptions10.Add("The Atmosphere.");
            TriviaQuestionAnswerOptions10.Add("The Mariana Trench.");
            TriviaQuestionAnswerOptions10.Add("The Cosmic Microwave Background.");
            TriviaQuestion TriviaQuestionToAdd10 = new TriviaQuestion("What is the coldest place in the universe?", TriviaQuestionAnswerOptions10, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd10);


            List<string> TriviaQuestionAnswerOptions11 = new List<string>();
            TriviaQuestionAnswerOptions11.Add("0.000003 Percent.");
            TriviaQuestionAnswerOptions11.Add("15.9 Percent.");
            TriviaQuestionAnswerOptions11.Add("99.999998 Percent.");
            TriviaQuestionAnswerOptions11.Add("The Milky Way is not visible from Earth.");
            TriviaQuestion TriviaQuestionToAdd11 = new TriviaQuestion("What percent of the Milky Way is visible from Earth?", TriviaQuestionAnswerOptions11, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd11);


            List<string> TriviaQuestionAnswerOptions12 = new List<string>();
            TriviaQuestionAnswerOptions12.Add("100 billion.");
            TriviaQuestionAnswerOptions12.Add("237 million.");
            TriviaQuestionAnswerOptions12.Add("17.9 billion.");
            TriviaQuestionAnswerOptions12.Add("We don’t know.");
            TriviaQuestion TriviaQuestionToAdd12 = new TriviaQuestion("How many stars are in the Milky Way?", TriviaQuestionAnswerOptions12, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd12);


            List<string> TriviaQuestionAnswerOptions13 = new List<string>();
            TriviaQuestionAnswerOptions13.Add("Dust, Rocks, Ice.");
            TriviaQuestionAnswerOptions13.Add("Hydrogen, Helium, Carbon.");
            TriviaQuestionAnswerOptions13.Add("Ice, Water, Gas.");
            TriviaQuestionAnswerOptions13.Add("Sugar, Spice, and a little bit of Everything.");
            TriviaQuestion TriviaQuestionToAdd13 = new TriviaQuestion("What three things are comets made of?", TriviaQuestionAnswerOptions13, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd13);

            List<string> TriviaQuestionAnswerOptions14 = new List<string>();
            TriviaQuestionAnswerOptions14.Add("Big Bang Theory.");
            TriviaQuestionAnswerOptions14.Add("Theory of Evolution.");
            TriviaQuestionAnswerOptions14.Add("Quantum Theory.");
            TriviaQuestionAnswerOptions14.Add("Heliocentric Theory.");
            TriviaQuestion TriviaQuestionToAdd14 = new TriviaQuestion("Which Theory describes the creation of the Universe?", TriviaQuestionAnswerOptions14, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd14);

            List<string> TriviaQuestionAnswerOptions15 = new List<string>();
            TriviaQuestionAnswerOptions15.Add("Spiral.");
            TriviaQuestionAnswerOptions15.Add("Elliptical.");
            TriviaQuestionAnswerOptions15.Add("Heliocentric.");
            TriviaQuestionAnswerOptions15.Add("The Milky Way is not a galaxy.");
            TriviaQuestion TriviaQuestionToAdd15 = new TriviaQuestion("What type of galaxy is the Milky Way?", TriviaQuestionAnswerOptions15, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd15);

            List<string> TriviaQuestionAnswerOptions16 = new List<string>();
            TriviaQuestionAnswerOptions16.Add("Polaris.");
            TriviaQuestionAnswerOptions16.Add("The Sun.");
            TriviaQuestionAnswerOptions16.Add("Alpha Centauri.");
            TriviaQuestionAnswerOptions16.Add("North West.");
            TriviaQuestion TriviaQuestionToAdd16 = new TriviaQuestion("What is another Name for the North Star?", TriviaQuestionAnswerOptions16, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd16);

            List<string> TriviaQuestionAnswerOptions17 = new List<string>();
            TriviaQuestionAnswerOptions17.Add("Blue.");
            TriviaQuestionAnswerOptions17.Add("Yellow.");
            TriviaQuestionAnswerOptions17.Add("Red.");
            TriviaQuestionAnswerOptions17.Add("White.");
            TriviaQuestion TriviaQuestionToAdd17 = new TriviaQuestion("What color is the hottest kind of star?", TriviaQuestionAnswerOptions17, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd17);

            List<string> TriviaQuestionAnswerOptions18 = new List<string>();
            TriviaQuestionAnswerOptions18.Add("Hobby Eberly Telescope.");
            TriviaQuestionAnswerOptions18.Add("James Webb Telescope.");
            TriviaQuestionAnswerOptions18.Add("Hubble Telescope.");
            TriviaQuestionAnswerOptions18.Add("Chandra X-Ray.");
            TriviaQuestion TriviaQuestionToAdd18 = new TriviaQuestion("Which of the following telescopes is not stationed in Space?", TriviaQuestionAnswerOptions18, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd18);

            List<string> TriviaQuestionAnswerOptions19 = new List<string>();
            TriviaQuestionAnswerOptions19.Add("James Webb Space Telescope.");
            TriviaQuestionAnswerOptions19.Add("Binoculars.");
            TriviaQuestionAnswerOptions19.Add("High-Energy Particle Detector.");
            TriviaQuestionAnswerOptions19.Add("Giant Magellan Telescope.");
            TriviaQuestion TriviaQuestionToAdd19 = new TriviaQuestion("What tool is used to detect distant galaxies?", TriviaQuestionAnswerOptions19, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd19);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions21 = new List<string>();
            TriviaQuestionAnswerOptions21.Add("Overwhelmingly Large Telescope.");
            TriviaQuestionAnswerOptions21.Add("100-Meter Aperture Space Telescope.");
            TriviaQuestionAnswerOptions21.Add("Thirty Meter Hale Telescope.");
            TriviaQuestionAnswerOptions21.Add("Gemini Lens X-Ray Telescope.");
            TriviaQuestion TriviaQuestionToAdd21 = new TriviaQuestion("What is the name of the conceptual telescope design created by the European Southern Observatory in 1998?", TriviaQuestionAnswerOptions21, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions22 = new List<string>();
            TriviaQuestionAnswerOptions22.Add("Over two trillion.");
            TriviaQuestionAnswerOptions22.Add("457.");
            TriviaQuestionAnswerOptions22.Add("Almost 19 billion.");
            TriviaQuestionAnswerOptions22.Add("15.");
            TriviaQuestion TriviaQuestionToAdd22 = new TriviaQuestion("How many galaxies do we know of?", TriviaQuestionAnswerOptions22, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd22);

            /*
            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);

            List<string> TriviaQuestionAnswerOptions20 = new List<string>();
            TriviaQuestionAnswerOptions20.Add("Microwave X-Ray Distant Ray Telescope.");
            TriviaQuestionAnswerOptions20.Add("Gran Telescopio Canarias.");
            TriviaQuestionAnswerOptions20.Add("Extremely Large Telescope.");
            TriviaQuestionAnswerOptions20.Add("500-meter Aperture Spherical Telescope.");
            TriviaQuestion TriviaQuestionToAdd20 = new TriviaQuestion("Which of the following is not the name of a telescope?", TriviaQuestionAnswerOptions20, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd20);
            */ 

            Utility.WriteTriviaToFile(ListofTriviaToWrite, Triviadatafiletouse);
        }
    }
}
