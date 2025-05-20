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

    /// <summary>
    /// this class holds all the stuff for writing new trivia to the file
    /// </summary>
    public class WritingNewTriviaToFile
    {
        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";

        /// <summary>
        /// writing all trivia to file for the first time
        /// </summary>
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
            
            List<string> TriviaQuestionAnswerOptions23 = new List<string>();
            TriviaQuestionAnswerOptions23.Add("One.");
            TriviaQuestionAnswerOptions23.Add("17.8 million.");
            TriviaQuestionAnswerOptions23.Add("Three trillion.");
            TriviaQuestionAnswerOptions23.Add("We can’t see any other galaxies.");
            TriviaQuestion TriviaQuestionToAdd23 = new TriviaQuestion("How many galaxies outside the Milky Way can we see with the naked eye?", TriviaQuestionAnswerOptions23, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd23);

            List<string> TriviaQuestionAnswerOptions24 = new List<string>();
            TriviaQuestionAnswerOptions24.Add("3,196.");
            TriviaQuestionAnswerOptions24.Add("14 Million.");
            TriviaQuestionAnswerOptions24.Add("187.");
            TriviaQuestionAnswerOptions24.Add("One.");
            TriviaQuestion TriviaQuestionToAdd24 = new TriviaQuestion("How many solar systems are estimated to be in the Milky Way?", TriviaQuestionAnswerOptions24, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd24);

            List<string> TriviaQuestionAnswerOptions25 = new List<string>();
            TriviaQuestionAnswerOptions25.Add("Neptune.");
            TriviaQuestionAnswerOptions25.Add("Mercury.");
            TriviaQuestionAnswerOptions25.Add("Venus.");
            TriviaQuestionAnswerOptions25.Add("Mars.");
            TriviaQuestion TriviaQuestionToAdd25 = new TriviaQuestion("Which of the following planets in our Solar System wouldn’t it be possible to walk on?", TriviaQuestionAnswerOptions25, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd25);

            List<string> TriviaQuestionAnswerOptions26 = new List<string>();
            TriviaQuestionAnswerOptions26.Add("Jupiter.");
            TriviaQuestionAnswerOptions26.Add("Earth.");
            TriviaQuestionAnswerOptions26.Add("Pluto.");
            TriviaQuestionAnswerOptions26.Add("Also Earth (duh?).");
            TriviaQuestion TriviaQuestionToAdd26 = new TriviaQuestion("Which planet has the largest ocean?", TriviaQuestionAnswerOptions26, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd26);

            List<string> TriviaQuestionAnswerOptions27 = new List<string>();
            TriviaQuestionAnswerOptions27.Add("165 Years.");
            TriviaQuestionAnswerOptions27.Add("Thirteen Days.");
            TriviaQuestionAnswerOptions27.Add("Twenty Years.");
            TriviaQuestionAnswerOptions27.Add("Four Hours");
            TriviaQuestion TriviaQuestionToAdd27 = new TriviaQuestion("How long (in relation to the Gregorian calendar system) is one year on Neptune?", TriviaQuestionAnswerOptions27, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd27);

            List<string> TriviaQuestionAnswerOptions28 = new List<string>();
            TriviaQuestionAnswerOptions28.Add("Celestial Flare.");
            TriviaQuestionAnswerOptions28.Add("Solar Storm.");
            TriviaQuestionAnswerOptions28.Add("Coronal Mass Ejection.");
            TriviaQuestionAnswerOptions28.Add("Radiation Storm.");
            TriviaQuestion TriviaQuestionToAdd28 = new TriviaQuestion("Which of the following is not a name for a storm produced by the Sun?", TriviaQuestionAnswerOptions28, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd28);

            List<string> TriviaQuestionAnswerOptions29 = new List<string>();
            TriviaQuestionAnswerOptions29.Add("Venus.");
            TriviaQuestionAnswerOptions29.Add("Mercury.");
            TriviaQuestionAnswerOptions29.Add("Saturn.");
            TriviaQuestionAnswerOptions29.Add("The Sun.");
            TriviaQuestion TriviaQuestionToAdd29 = new TriviaQuestion("What is the hottest planet in our Solar System?", TriviaQuestionAnswerOptions29, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd29);

            List<string> TriviaQuestionAnswerOptions30 = new List<string>();
            TriviaQuestionAnswerOptions30.Add("Solar System.");
            TriviaQuestionAnswerOptions30.Add("solar system.");
            TriviaQuestionAnswerOptions30.Add("SOLAR SYSTEM.");
            TriviaQuestionAnswerOptions30.Add("Solar system.");
            TriviaQuestion TriviaQuestionToAdd30 = new TriviaQuestion("Which of the following terms for describing our section of the galaxy is capitalised correctly?", TriviaQuestionAnswerOptions30, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd30);

            List<string> TriviaQuestionAnswerOptions31 = new List<string>();
            TriviaQuestionAnswerOptions31.Add("Earth.");
            TriviaQuestionAnswerOptions31.Add("Mercury.");
            TriviaQuestionAnswerOptions31.Add("Pluto.");
            TriviaQuestionAnswerOptions31.Add("Uranus.");
            TriviaQuestion TriviaQuestionToAdd31 = new TriviaQuestion("Which of the following planets is not named after a god?", TriviaQuestionAnswerOptions31, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd31);

            List<string> TriviaQuestionAnswerOptions32 = new List<string>();
            TriviaQuestionAnswerOptions32.Add("One Million.");
            TriviaQuestionAnswerOptions32.Add("Two Thousand.");
            TriviaQuestionAnswerOptions32.Add("Thirty.");
            TriviaQuestionAnswerOptions32.Add("Seven Hundred.");
            TriviaQuestion TriviaQuestionToAdd32 = new TriviaQuestion("Approximately how many Earths could fit inside the Sun?", TriviaQuestionAnswerOptions32, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd32);

            List<string> TriviaQuestionAnswerOptions33 = new List<string>();
            TriviaQuestionAnswerOptions33.Add("Corona.");
            TriviaQuestionAnswerOptions33.Add("Radiative Zone.");
            TriviaQuestionAnswerOptions33.Add("Transition Zone.");
            TriviaQuestionAnswerOptions33.Add("Chromosphere.");
            TriviaQuestion TriviaQuestionToAdd33 = new TriviaQuestion("Which of the following is the Sun’s outermost layer?", TriviaQuestionAnswerOptions33, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd33);

            List<string> TriviaQuestionAnswerOptions34 = new List<string>();
            TriviaQuestionAnswerOptions34.Add("Third.");
            TriviaQuestionAnswerOptions34.Add("Fifth.");
            TriviaQuestionAnswerOptions34.Add("Fourteenth.");
            TriviaQuestionAnswerOptions34.Add("First.");
            TriviaQuestion TriviaQuestionToAdd34 = new TriviaQuestion("When ranking all celestial objects by their apparent brightness in our sky, what ranking is Venus?", TriviaQuestionAnswerOptions34, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd34);

            List<string> TriviaQuestionAnswerOptions35 = new List<string>();
            TriviaQuestionAnswerOptions35.Add("Blue.");
            TriviaQuestionAnswerOptions35.Add("Yellow.");
            TriviaQuestionAnswerOptions35.Add("Red.");
            TriviaQuestionAnswerOptions35.Add("White.");
            TriviaQuestion TriviaQuestionToAdd35 = new TriviaQuestion("What color is the sunset on Mars?", TriviaQuestionAnswerOptions35, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd35);

            List<string> TriviaQuestionAnswerOptions36 = new List<string>();
            TriviaQuestionAnswerOptions36.Add("Saturn.");
            TriviaQuestionAnswerOptions36.Add("Earth.");
            TriviaQuestionAnswerOptions36.Add("Jupiter.");
            TriviaQuestionAnswerOptions36.Add("Uranus.");
            TriviaQuestion TriviaQuestionToAdd36 = new TriviaQuestion("What planet does the moon Titan orbit?", TriviaQuestionAnswerOptions36, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd36);

            List<string> TriviaQuestionAnswerOptions37 = new List<string>();
            TriviaQuestionAnswerOptions37.Add("Sol.");
            TriviaQuestionAnswerOptions37.Add("Sidereal Day.");
            TriviaQuestionAnswerOptions37.Add("Rotation.");
            TriviaQuestionAnswerOptions37.Add("Jovia.");
            TriviaQuestion TriviaQuestionToAdd37 = new TriviaQuestion("What is a day on Mars called?", TriviaQuestionAnswerOptions37, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd37);

            List<string> TriviaQuestionAnswerOptions38 = new List<string>();
            TriviaQuestionAnswerOptions38.Add("Venus.");
            TriviaQuestionAnswerOptions37.Add("Earth.");
            TriviaQuestionAnswerOptions37.Add("Uranus.");
            TriviaQuestionAnswerOptions37.Add("Neptune.");
            TriviaQuestion TriviaQuestionToAdd38 = new TriviaQuestion("Which of the following planets does not have a moon", TriviaQuestionAnswerOptions38, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd38);

            List<string> TriviaQuestionAnswerOptions39 = new List<string>();
            TriviaQuestionAnswerOptions39.Add("It hasn’t cleared the area around its orbit.");
            TriviaQuestionAnswerOptions39.Add("It doesn’t orbit a star.");
            TriviaQuestionAnswerOptions39.Add("It doesn’t have any moons.");
            TriviaQuestionAnswerOptions39.Add("It lacks an atmosphere.");
            TriviaQuestion TriviaQuestionToAdd39 = new TriviaQuestion("For which of the following reasons is Pluto not considered a planet?", TriviaQuestionAnswerOptions39, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd39);

            List<string> TriviaQuestionAnswerOptions40 = new List<string>();
            TriviaQuestionAnswerOptions40.Add("Saturn.");
            TriviaQuestionAnswerOptions40.Add("Jupiter.");
            TriviaQuestionAnswerOptions40.Add("Uranus.");
            TriviaQuestionAnswerOptions40.Add("Each planet has only one moon.");
            TriviaQuestion TriviaQuestionToAdd40 = new TriviaQuestion("Which planet has the most moons?", TriviaQuestionAnswerOptions40, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd40);

            List<string> TriviaQuestionAnswerOptions41 = new List<string>();
            TriviaQuestionAnswerOptions41.Add("95.");
            TriviaQuestionAnswerOptions41.Add("15.");
            TriviaQuestionAnswerOptions41.Add("274.");
            TriviaQuestionAnswerOptions41.Add("83.");
            TriviaQuestion TriviaQuestionToAdd41 = new TriviaQuestion("How many moons does Jupiter have?", TriviaQuestionAnswerOptions41, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd41);

            List<string> TriviaQuestionAnswerOptions42 = new List<string>();
            TriviaQuestionAnswerOptions42.Add("274.");
            TriviaQuestionAnswerOptions42.Add("83.");
            TriviaQuestionAnswerOptions42.Add("15.");
            TriviaQuestionAnswerOptions42.Add("95.");
            TriviaQuestion TriviaQuestionToAdd42 = new TriviaQuestion("How many moons does Saturn have?", TriviaQuestionAnswerOptions42, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd30);

            List<string> TriviaQuestionAnswerOptions43 = new List<string>();
            TriviaQuestionAnswerOptions43.Add("2006.");
            TriviaQuestionAnswerOptions43.Add("2003.");
            TriviaQuestionAnswerOptions43.Add("2015.");
            TriviaQuestionAnswerOptions43.Add("1998.");
            TriviaQuestion TriviaQuestionToAdd43 = new TriviaQuestion("In what year was Pluto reclassified as a dwarf planet?", TriviaQuestionAnswerOptions43, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd43);

            List<string> TriviaQuestionAnswerOptions44 = new List<string>();
            TriviaQuestionAnswerOptions44.Add("National Aeronautics and Space Administration.");
            TriviaQuestionAnswerOptions44.Add("New American Soviet Alliance.");
            TriviaQuestionAnswerOptions44.Add("National Astronomy and Space Agency.");
            TriviaQuestionAnswerOptions44.Add("National Astronautical Satellite Agency.");
            TriviaQuestion TriviaQuestionToAdd44 = new TriviaQuestion("What does NASA stand for?", TriviaQuestionAnswerOptions44, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd44);

            List<string> TriviaQuestionAnswerOptions45 = new List<string>();
            TriviaQuestionAnswerOptions45.Add("Apollo 11.");
            TriviaQuestionAnswerOptions45.Add("Apollo 13.");
            TriviaQuestionAnswerOptions45.Add("Apollo 9.");
            TriviaQuestionAnswerOptions45.Add("Sputnik.");
            TriviaQuestion TriviaQuestionToAdd45 = new TriviaQuestion("What spacecraft first brought astronauts to the Moon?", TriviaQuestionAnswerOptions45, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd45);

            List<string> TriviaQuestionAnswerOptions46 = new List<string>();
            TriviaQuestionAnswerOptions46.Add("The former refers to Americans, and the latter refers to Soviets.");
            TriviaQuestionAnswerOptions46.Add("The former is the American spelling, and the latter is the British spelling.");
            TriviaQuestionAnswerOptions46.Add("The former focus on planets, and the latter focus on the atmosphere.");
            TriviaQuestionAnswerOptions46.Add("There is no difference.");
            TriviaQuestion TriviaQuestionToAdd46 = new TriviaQuestion("What is the difference between astronauts and cosmonauts?", TriviaQuestionAnswerOptions46, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd46);

            List<string> TriviaQuestionAnswerOptions47 = new List<string>();
            TriviaQuestionAnswerOptions47.Add("1963.");
            TriviaQuestionAnswerOptions47.Add("2007.");
            TriviaQuestionAnswerOptions47.Add("1984.");
            TriviaQuestionAnswerOptions47.Add("2000.");
            TriviaQuestion TriviaQuestionToAdd47 = new TriviaQuestion("What year did the first woman go to space?", TriviaQuestionAnswerOptions47, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd47);

            List<string> TriviaQuestionAnswerOptions48 = new List<string>();
            TriviaQuestionAnswerOptions48.Add("Voyager 2.");
            TriviaQuestionAnswerOptions48.Add("Apollo 11.");
            TriviaQuestionAnswerOptions48.Add("Gemini.");
            TriviaQuestionAnswerOptions48.Add("Apollo 3.");
            TriviaQuestion TriviaQuestionToAdd48 = new TriviaQuestion("What was the only spacecraft to visit Uranus?", TriviaQuestionAnswerOptions48, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd48);

            List<string> TriviaQuestionAnswerOptions49 = new List<string>();
            TriviaQuestionAnswerOptions49.Add("International Space Station.");
            TriviaQuestionAnswerOptions49.Add("Intergalactic Space Sector.");
            TriviaQuestionAnswerOptions49.Add("Intermediate Shooting Star.");
            TriviaQuestionAnswerOptions49.Add("International Space Solutions.");
            TriviaQuestion TriviaQuestionToAdd49 = new TriviaQuestion("What does I.S.S. stand for in the context of space?", TriviaQuestionAnswerOptions49, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd49);

            List<string> TriviaQuestionAnswerOptions50 = new List<string>();
            TriviaQuestionAnswerOptions50.Add("Peggy Whitson.");
            TriviaQuestionAnswerOptions50.Add("Sally Ride.");
            TriviaQuestionAnswerOptions50.Add("Valentina Tereshkova.");
            TriviaQuestionAnswerOptions50.Add("Barbara Morgan.");
            TriviaQuestion TriviaQuestionToAdd50 = new TriviaQuestion("Who was the first female commander of the International Space Station?", TriviaQuestionAnswerOptions50, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd50);

            List<string> TriviaQuestionAnswerOptions51 = new List<string>();
            TriviaQuestionAnswerOptions51.Add("Eros.");
            TriviaQuestionAnswerOptions51.Add("Psyche.");
            TriviaQuestionAnswerOptions51.Add("Juno.");
            TriviaQuestionAnswerOptions51.Add("Europa.");
            TriviaQuestion TriviaQuestionToAdd51 = new TriviaQuestion("What was the first asteroid to be landed on by a space probe?", TriviaQuestionAnswerOptions51, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd51);

            List<string> TriviaQuestionAnswerOptions52 = new List<string>();
            TriviaQuestionAnswerOptions52.Add("Dog.");
            TriviaQuestionAnswerOptions52.Add("Lizard.");
            TriviaQuestionAnswerOptions52.Add("Fly.");
            TriviaQuestionAnswerOptions52.Add("Cockroach.");
            TriviaQuestion TriviaQuestionToAdd52 = new TriviaQuestion("Which animal was the first to be in orbit?", TriviaQuestionAnswerOptions52, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd52);

            List<string> TriviaQuestionAnswerOptions53 = new List<string>();
            TriviaQuestionAnswerOptions53.Add("Laika.");
            TriviaQuestionAnswerOptions53.Add("Belka.");
            TriviaQuestionAnswerOptions53.Add("Strelka.");
            TriviaQuestionAnswerOptions53.Add("Veterok.");
            TriviaQuestion TriviaQuestionToAdd53 = new TriviaQuestion("What was the name of the first dog in space?", TriviaQuestionAnswerOptions53, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd53);

            List<string> TriviaQuestionAnswerOptions54 = new List<string>();
            TriviaQuestionAnswerOptions54.Add("88.");
            TriviaQuestionAnswerOptions54.Add("14,720.");
            TriviaQuestionAnswerOptions54.Add("14.");
            TriviaQuestionAnswerOptions54.Add("There are infinite possible constellations.");
            TriviaQuestion TriviaQuestionToAdd54 = new TriviaQuestion("How many constellations are there?", TriviaQuestionAnswerOptions54, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd54);

            List<string> TriviaQuestionAnswerOptions55 = new List<string>();
            TriviaQuestionAnswerOptions55.Add("7.");
            TriviaQuestionAnswerOptions55.Add("18.");
            TriviaQuestionAnswerOptions55.Add("247.");
            TriviaQuestionAnswerOptions55.Add("2.");
            TriviaQuestion TriviaQuestionToAdd55 = new TriviaQuestion("How many stars make up the Big Dipper?", TriviaQuestionAnswerOptions55, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd55);

            List<string> TriviaQuestionAnswerOptions56 = new List<string>();
            TriviaQuestionAnswerOptions56.Add("SpaceX.");
            TriviaQuestionAnswerOptions56.Add("Boeing.");
            TriviaQuestionAnswerOptions56.Add("Blue Origin.");
            TriviaQuestionAnswerOptions56.Add("Virgin Galactic.");
            TriviaQuestion TriviaQuestionToAdd56 = new TriviaQuestion("Which private company was the first to launch a rocket into space?", TriviaQuestionAnswerOptions56, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd56);

            List<string> TriviaQuestionAnswerOptions57 = new List<string>();
            TriviaQuestionAnswerOptions57.Add("Jupiter.");
            TriviaQuestionAnswerOptions57.Add("Earth.");
            TriviaQuestionAnswerOptions57.Add("Saturn.");
            TriviaQuestionAnswerOptions57.Add("Neptune.");
            TriviaQuestion TriviaQuestionToAdd57 = new TriviaQuestion("Aside from Earth, which planet’s moons were the first to be discovered?", TriviaQuestionAnswerOptions57, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd57);

            List<string> TriviaQuestionAnswerOptions58 = new List<string>();
            TriviaQuestionAnswerOptions58.Add("Voyager 1.");
            TriviaQuestionAnswerOptions58.Add("Voyager 2.");
            TriviaQuestionAnswerOptions58.Add("Apollo 11.");
            TriviaQuestionAnswerOptions58.Add("Pioneer 10.");
            TriviaQuestion TriviaQuestionToAdd58 = new TriviaQuestion("What was the first spacecraft to enter interstellar space?", TriviaQuestionAnswerOptions58, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd58);

            List<string> TriviaQuestionAnswerOptions59 = new List<string>();
            TriviaQuestionAnswerOptions59.Add("Uranus.");
            TriviaQuestionAnswerOptions59.Add("Jupiter.");
            TriviaQuestionAnswerOptions59.Add("Mars.");
            TriviaQuestionAnswerOptions59.Add("Neptune.");
            TriviaQuestion TriviaQuestionToAdd59 = new TriviaQuestion("What was the first planet found using a telescope?", TriviaQuestionAnswerOptions59, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd59);

            List<string> TriviaQuestionAnswerOptions60 = new List<string>();
            TriviaQuestionAnswerOptions60.Add("Apollo 13.");
            TriviaQuestionAnswerOptions60.Add("Apollo 11.");
            TriviaQuestionAnswerOptions60.Add("Sputnik 1.");
            TriviaQuestionAnswerOptions60.Add("Challenger.");
            TriviaQuestion TriviaQuestionToAdd60 = new TriviaQuestion("Which spacecraft was famously repaired using duct tape?", TriviaQuestionAnswerOptions60, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd60);

            List<string> TriviaQuestionAnswerOptions61 = new List<string>();
            TriviaQuestionAnswerOptions61.Add("682.");
            TriviaQuestionAnswerOptions61.Add("82.");
            TriviaQuestionAnswerOptions61.Add("126.");
            TriviaQuestionAnswerOptions61.Add("103.");
            TriviaQuestion TriviaQuestionToAdd61 = new TriviaQuestion("How many humans have been in space as of March 2025?", TriviaQuestionAnswerOptions61, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd61);

            List<string> TriviaQuestionAnswerOptions62 = new List<string>();
            TriviaQuestionAnswerOptions62.Add("104.");
            TriviaQuestionAnswerOptions62.Add("12.");
            TriviaQuestionAnswerOptions62.Add("3.");
            TriviaQuestionAnswerOptions62.Add("318.");
            TriviaQuestion TriviaQuestionToAdd62 = new TriviaQuestion("How many women have been in space as of April 2025?", TriviaQuestionAnswerOptions62, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd62);

            List<string> TriviaQuestionAnswerOptions63 = new List<string>();
            TriviaQuestionAnswerOptions63.Add("11%.");
            TriviaQuestionAnswerOptions63.Add("4%.");
            TriviaQuestionAnswerOptions63.Add("50%.");
            TriviaQuestionAnswerOptions63.Add("36%.");
            TriviaQuestion TriviaQuestionToAdd63 = new TriviaQuestion("As of 2025, what percent of people who have been in space are women?", TriviaQuestionAnswerOptions63, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd63);

            List<string> TriviaQuestionAnswerOptions64 = new List<string>();
            TriviaQuestionAnswerOptions64.Add("12.");
            TriviaQuestionAnswerOptions64.Add("3.");
            TriviaQuestionAnswerOptions64.Add("107.");
            TriviaQuestionAnswerOptions64.Add("34.");
            TriviaQuestion TriviaQuestionToAdd64 = new TriviaQuestion("How many humans have been on the Moon?", TriviaQuestionAnswerOptions64, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd64);

            List<string> TriviaQuestionAnswerOptions65 = new List<string>();
            TriviaQuestionAnswerOptions65.Add("No women have ever been on the Moon.");
            TriviaQuestionAnswerOptions65.Add("14.");
            TriviaQuestionAnswerOptions65.Add("3.");
            TriviaQuestionAnswerOptions65.Add("7.");
            TriviaQuestion TriviaQuestionToAdd65 = new TriviaQuestion("How many women have been on the Moon?", TriviaQuestionAnswerOptions65, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd65);

            List<string> TriviaQuestionAnswerOptions66 = new List<string>();
            TriviaQuestionAnswerOptions66.Add("1 Billion USD.");
            TriviaQuestionAnswerOptions66.Add("17 Million USD.");
            TriviaQuestionAnswerOptions66.Add("40 Thousand USD.");
            TriviaQuestionAnswerOptions66.Add("9.3 Million USD.");
            TriviaQuestion TriviaQuestionToAdd66 = new TriviaQuestion("What is the estimated cost of the latest NASA space suit?", TriviaQuestionAnswerOptions66, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd66);

            List<string> TriviaQuestionAnswerOptions67 = new List<string>();
            TriviaQuestionAnswerOptions67.Add("The space between star systems.");
            TriviaQuestionAnswerOptions67.Add("The area immediately around our Sun.");
            TriviaQuestionAnswerOptions67.Add("The space that exists within our star system.");
            TriviaQuestionAnswerOptions67.Add("A really good movie.");
            TriviaQuestion TriviaQuestionToAdd67 = new TriviaQuestion("In the context of astronomy, what is Interstellar Space?", TriviaQuestionAnswerOptions67, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd67);

            List<string> TriviaQuestionAnswerOptions68 = new List<string>();
            TriviaQuestionAnswerOptions68.Add("1972.");
            TriviaQuestionAnswerOptions68.Add("2025.");
            TriviaQuestionAnswerOptions68.Add("2009.");
            TriviaQuestionAnswerOptions68.Add("2016.");
            TriviaQuestion TriviaQuestionToAdd68 = new TriviaQuestion("In what year did humans last set foot on the Moon?", TriviaQuestionAnswerOptions68, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd68);

            List<string> TriviaQuestionAnswerOptions69 = new List<string>();
            TriviaQuestionAnswerOptions69.Add("Apollo 17.");
            TriviaQuestionAnswerOptions69.Add("Apollo 13.");
            TriviaQuestionAnswerOptions69.Add("Apollo 11.");
            TriviaQuestionAnswerOptions69.Add("Apollo 15.");
            TriviaQuestion TriviaQuestionToAdd69 = new TriviaQuestion("What was the name of the last manned mission to the Moon?", TriviaQuestionAnswerOptions69, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd69);

            List<string> TriviaQuestionAnswerOptions70 = new List<string>();
            TriviaQuestionAnswerOptions70.Add("75 Hours.");
            TriviaQuestionAnswerOptions70.Add("14 Hours.");
            TriviaQuestionAnswerOptions70.Add("183 Hours.");
            TriviaQuestionAnswerOptions70.Add("Humans have never been on the Moon.");
            TriviaQuestion TriviaQuestionToAdd70 = new TriviaQuestion("What is the most time any human has spent on the Moon?", TriviaQuestionAnswerOptions70, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd70);

            List<string> TriviaQuestionAnswerOptions71 = new List<string>();
            TriviaQuestionAnswerOptions71.Add("2027.");
            TriviaQuestionAnswerOptions71.Add("2026.");
            TriviaQuestionAnswerOptions71.Add("2031.");
            TriviaQuestionAnswerOptions71.Add("There are no scheduled Moon landings.");
            TriviaQuestion TriviaQuestionToAdd71 = new TriviaQuestion("In what year is the next scheduled Moon landing?", TriviaQuestionAnswerOptions71, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd71);

            List<string> TriviaQuestionAnswerOptions72 = new List<string>();
            TriviaQuestionAnswerOptions72.Add("No manned spacecrafts went to the Moon in 2007.");
            TriviaQuestionAnswerOptions72.Add("Apollo 19.");
            TriviaQuestionAnswerOptions72.Add("Gemini 4.");
            TriviaQuestionAnswerOptions72.Add("Apollo 17.");
            TriviaQuestion TriviaQuestionToAdd72 = new TriviaQuestion("What spacecraft took a crew to the Moon in 2007?", TriviaQuestionAnswerOptions72, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd72);

            List<string> TriviaQuestionAnswerOptions73 = new List<string>();
            TriviaQuestionAnswerOptions73.Add("Artemis III.");
            TriviaQuestionAnswerOptions73.Add("Apollo 19.");
            TriviaQuestionAnswerOptions73.Add("Artemis IV.");
            TriviaQuestionAnswerOptions73.Add("Apollo 18.");
            TriviaQuestion TriviaQuestionToAdd73 = new TriviaQuestion("What is the name of the next planned crewed mission to land on the Moon?", TriviaQuestionAnswerOptions73, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd73);

            List<string> TriviaQuestionAnswerOptions74 = new List<string>();
            TriviaQuestionAnswerOptions74.Add("An invisible bubble that surrounds the Solar System.");
            TriviaQuestionAnswerOptions74.Add("The Sun’s atmosphere.");
            TriviaQuestionAnswerOptions74.Add("The livable region of our Solar System.");
            TriviaQuestionAnswerOptions74.Add("The theory that the Earth and other planets revolve around the Sun.");
            TriviaQuestion TriviaQuestionToAdd74 = new TriviaQuestion("What is the Heliosphere?", TriviaQuestionAnswerOptions74, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd74);

            List<string> TriviaQuestionAnswerOptions75 = new List<string>();
            TriviaQuestionAnswerOptions75.Add("The boundary where the Sun’s solar wind crashes against interstellar space.");
            TriviaQuestionAnswerOptions75.Add("A part of the Sun’s annual cycle.");
            TriviaQuestionAnswerOptions75.Add("A theoretical scenario where the Sun ceases to turn.");
            TriviaQuestionAnswerOptions75.Add("The area beyond our Solar System where the Sun’s light and warmth can no longer be felt.");
            TriviaQuestion TriviaQuestionToAdd75 = new TriviaQuestion("What is the Heliopause?", TriviaQuestionAnswerOptions75, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd75);

            List<string> TriviaQuestionAnswerOptions76 = new List<string>();
            TriviaQuestionAnswerOptions76.Add("8.");
            TriviaQuestionAnswerOptions76.Add("9.");
            TriviaQuestionAnswerOptions76.Add("1.");
            TriviaQuestionAnswerOptions76.Add("1.");
            TriviaQuestion TriviaQuestionToAdd76 = new TriviaQuestion("How many planets are in our Solar System?", TriviaQuestionAnswerOptions76, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd76);

            List<string> TriviaQuestionAnswerOptions77 = new List<string>();
            TriviaQuestionAnswerOptions77.Add("Dwarf Planet.");
            TriviaQuestionAnswerOptions77.Add("Regular Planet.");
            TriviaQuestionAnswerOptions77.Add("Asteroid.");
            TriviaQuestionAnswerOptions77.Add("Exoplanet.");
            TriviaQuestion TriviaQuestionToAdd77 = new TriviaQuestion("What is Pluto classified as?", TriviaQuestionAnswerOptions77, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd77);

            List<string> TriviaQuestionAnswerOptions78 = new List<string>();
            TriviaQuestionAnswerOptions78.Add("1930.");
            TriviaQuestionAnswerOptions78.Add("2001.");
            TriviaQuestionAnswerOptions78.Add("1969.");
            TriviaQuestionAnswerOptions78.Add("1845.");
            TriviaQuestion TriviaQuestionToAdd78 = new TriviaQuestion("In what year was Pluto discovered?", TriviaQuestionAnswerOptions78, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd78);

            List<string> TriviaQuestionAnswerOptions79 = new List<string>();
            TriviaQuestionAnswerOptions79.Add("2006.");
            TriviaQuestionAnswerOptions79.Add("1987.");
            TriviaQuestionAnswerOptions79.Add("2014.");
            TriviaQuestionAnswerOptions79.Add("Pluto is still a planet.");
            TriviaQuestion TriviaQuestionToAdd79 = new TriviaQuestion("In what year was Pluto declassified as a planet?", TriviaQuestionAnswerOptions79, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd79);

            List<string> TriviaQuestionAnswerOptions80 = new List<string>();
            TriviaQuestionAnswerOptions80.Add("One.");
            TriviaQuestionAnswerOptions80.Add("Three.");
            TriviaQuestionAnswerOptions80.Add("Two.");
            TriviaQuestionAnswerOptions80.Add("Eight.");
            TriviaQuestion TriviaQuestionToAdd80 = new TriviaQuestion("How many planets in our Solar System are known to be able to support life?", TriviaQuestionAnswerOptions80, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd80);

            List<string> TriviaQuestionAnswerOptions81 = new List<string>();
            TriviaQuestionAnswerOptions81.Add("No other planets are known to be capable of supporting life.");
            TriviaQuestionAnswerOptions81.Add("Venus.");
            TriviaQuestionAnswerOptions81.Add("Mars.");
            TriviaQuestionAnswerOptions81.Add("Jupiter.");
            TriviaQuestion TriviaQuestionToAdd81 = new TriviaQuestion("Aside from Earth, which planet in our Solar System is known to be capable of supporting life?", TriviaQuestionAnswerOptions81, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd81);

            List<string> TriviaQuestionAnswerOptions82 = new List<string>();
            TriviaQuestionAnswerOptions82.Add("Challenger.");
            TriviaQuestionAnswerOptions82.Add("Apollo 8.");
            TriviaQuestionAnswerOptions82.Add("Apollo 3.");
            TriviaQuestionAnswerOptions82.Add("Sputnik 3.");
            TriviaQuestion TriviaQuestionToAdd82 = new TriviaQuestion("Which of the following spacecraft famously exploded right after takeoff?", TriviaQuestionAnswerOptions82, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd82);

            List<string> TriviaQuestionAnswerOptions83 = new List<string>();
            TriviaQuestionAnswerOptions83.Add("73 Seconds.");
            TriviaQuestionAnswerOptions83.Add("12 Minutes.");
            TriviaQuestionAnswerOptions83.Add("1 Hour.");
            TriviaQuestionAnswerOptions83.Add("4 Minutes.");
            TriviaQuestion TriviaQuestionToAdd83 = new TriviaQuestion("How long after takeoff did the Challenger space shuttle explode?", TriviaQuestionAnswerOptions83, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd83);

            List<string> TriviaQuestionAnswerOptions84 = new List<string>();
            TriviaQuestionAnswerOptions84.Add("Christa McAuliffe.");
            TriviaQuestionAnswerOptions84.Add("Sally Ride.");
            TriviaQuestionAnswerOptions84.Add("Ronald J. Smith.");
            TriviaQuestionAnswerOptions84.Add("Nick Francis.");
            TriviaQuestion TriviaQuestionToAdd84 = new TriviaQuestion("Who was the schoolteacher slated to be the first civilian in space?", TriviaQuestionAnswerOptions84, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd84);

            List<string> TriviaQuestionAnswerOptions85 = new List<string>();
            TriviaQuestionAnswerOptions85.Add("1986.");
            TriviaQuestionAnswerOptions85.Add("2003.");
            TriviaQuestionAnswerOptions85.Add("2017.");
            TriviaQuestionAnswerOptions85.Add("1962.");
            TriviaQuestion TriviaQuestionToAdd85 = new TriviaQuestion("In what year did the Challenger space shuttle explode?", TriviaQuestionAnswerOptions85, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd85);

            List<string> TriviaQuestionAnswerOptions86 = new List<string>();
            TriviaQuestionAnswerOptions86.Add("2023.");
            TriviaQuestionAnswerOptions86.Add("2010.");
            TriviaQuestionAnswerOptions86.Add("2025.");
            TriviaQuestionAnswerOptions86.Add("1998.");
            TriviaQuestion TriviaQuestionToAdd86 = new TriviaQuestion("In what year was the first commercial space flight?", TriviaQuestionAnswerOptions86, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd86);

            List<string> TriviaQuestionAnswerOptions87 = new List<string>();
            TriviaQuestionAnswerOptions87.Add("Yuri Gagarin.");
            TriviaQuestionAnswerOptions87.Add("Alan Shepard.");
            TriviaQuestionAnswerOptions87.Add("Neil Armstrong.");
            TriviaQuestionAnswerOptions87.Add("Virgil Grissom.");
            TriviaQuestion TriviaQuestionToAdd87 = new TriviaQuestion("Who was the first human being in space?", TriviaQuestionAnswerOptions87, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd87);

            List<string> TriviaQuestionAnswerOptions88 = new List<string>();
            TriviaQuestionAnswerOptions88.Add("Alan Shepard.");
            TriviaQuestionAnswerOptions88.Add("Neil Armstrong.");
            TriviaQuestionAnswerOptions88.Add("Yuri Gagarin.");
            TriviaQuestionAnswerOptions88.Add("Virgil Grissom.");
            TriviaQuestion TriviaQuestionToAdd88 = new TriviaQuestion("Who was the first American in space?", TriviaQuestionAnswerOptions88, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd88);

            List<string> TriviaQuestionAnswerOptions89 = new List<string>();
            TriviaQuestionAnswerOptions89.Add("Neil Armstrong.");
            TriviaQuestionAnswerOptions89.Add("Yuri Gagarin.");
            TriviaQuestionAnswerOptions89.Add("Alan Shepard.");
            TriviaQuestionAnswerOptions89.Add("Buzz Aldrin.");
            TriviaQuestion TriviaQuestionToAdd89 = new TriviaQuestion("Who was the first person to step on the Moon?", TriviaQuestionAnswerOptions89, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd89);

            List<string> TriviaQuestionAnswerOptions90 = new List<string>();
            TriviaQuestionAnswerOptions90.Add("1969.");
            TriviaQuestionAnswerOptions90.Add("1968.");
            TriviaQuestionAnswerOptions90.Add("2001.");
            TriviaQuestionAnswerOptions90.Add("1965.");
            TriviaQuestion TriviaQuestionToAdd90 = new TriviaQuestion("When did the first human set foot on the Moon?", TriviaQuestionAnswerOptions90, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd90);

            List<string> TriviaQuestionAnswerOptions91 = new List<string>();
            TriviaQuestionAnswerOptions91.Add("July 16.");
            TriviaQuestionAnswerOptions91.Add("July 20.");
            TriviaQuestionAnswerOptions91.Add("September 11.");
            TriviaQuestionAnswerOptions91.Add("June 19.");
            TriviaQuestion TriviaQuestionToAdd91 = new TriviaQuestion("What was the date of the first moon landing?", TriviaQuestionAnswerOptions91, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd91);

            List<string> TriviaQuestionAnswerOptions92 = new List<string>();
            TriviaQuestionAnswerOptions92.Add("As a tribute to the strength of our nation.");
            TriviaQuestionAnswerOptions92.Add("July 1969 A.D.");
            TriviaQuestionAnswerOptions92.Add("We came in peace for all mankind.");
            TriviaQuestionAnswerOptions92.Add("Here men from the planet Earth first set foot upon the moon.");
            TriviaQuestion TriviaQuestionToAdd92 = new TriviaQuestion("Which of the following phrases was not inscribed on the plaque left on the Moon by the crew of Apollo 11?", TriviaQuestionAnswerOptions92, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd92);

            List<string> TriviaQuestionAnswerOptions93 = new List<string>();
            TriviaQuestionAnswerOptions93.Add("Kennedy.");
            TriviaQuestionAnswerOptions93.Add("Nixon.");
            TriviaQuestionAnswerOptions93.Add("Johnson.");
            TriviaQuestionAnswerOptions93.Add("Eisenhower.");
            TriviaQuestion TriviaQuestionToAdd93 = new TriviaQuestion("Which United States President famously promised to send a man to the Moon before 1970?", TriviaQuestionAnswerOptions93, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd93);

            List<string> TriviaQuestionAnswerOptions94 = new List<string>();
            TriviaQuestionAnswerOptions94.Add("We Choose the Moon.");
            TriviaQuestionAnswerOptions94.Add("I Have a Dream.");
            TriviaQuestionAnswerOptions94.Add("The American Space Effort.");
            TriviaQuestionAnswerOptions94.Add("Sending Humanity to the Stars.");
            TriviaQuestion TriviaQuestionToAdd94 = new TriviaQuestion("What was the name of the famous speech in which President Kennedy committed America to sending a man to the Moon?", TriviaQuestionAnswerOptions94, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd94);

            List<string> TriviaQuestionAnswerOptions95 = new List<string>();
            TriviaQuestionAnswerOptions95.Add("Voyager 1.");
            TriviaQuestionAnswerOptions95.Add("Gemini.");
            TriviaQuestionAnswerOptions95.Add("Apollo 13.");
            TriviaQuestionAnswerOptions95.Add("Voyager 3.");
            TriviaQuestion TriviaQuestionToAdd95 = new TriviaQuestion("Which of the following spacecraft carries a copy of the Golden Record?", TriviaQuestionAnswerOptions95, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd95);

            List<string> TriviaQuestionAnswerOptions96 = new List<string>();
            TriviaQuestionAnswerOptions96.Add("A disk with information on Earth sent into space for aliens to find.");
            TriviaQuestionAnswerOptions96.Add("An list of deceased NASA astronauts carried aboard each space shuttle.");
            TriviaQuestionAnswerOptions96.Add("The circular plaque left on the Moon by the Apollo 11 crew.");
            TriviaQuestionAnswerOptions96.Add("A playlist created by NASA of space sounds.");
            TriviaQuestion TriviaQuestionToAdd96 = new TriviaQuestion("What is the Golden Record?", TriviaQuestionAnswerOptions96, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd96);

            List<string> TriviaQuestionAnswerOptions97 = new List<string>();
            TriviaQuestionAnswerOptions97.Add("55.");
            TriviaQuestionAnswerOptions97.Add("3.");
            TriviaQuestionAnswerOptions97.Add("14.");
            TriviaQuestionAnswerOptions97.Add("127.");
            TriviaQuestion TriviaQuestionToAdd97 = new TriviaQuestion("In how many languages does the Golden Record contain greetings?", TriviaQuestionAnswerOptions97, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd97);

            List<string> TriviaQuestionAnswerOptions98 = new List<string>();
            TriviaQuestionAnswerOptions98.Add("The area around a star where a habitable planet could form.");
            TriviaQuestionAnswerOptions98.Add("A region of space where stars are named exclusively after fairytales and myths.");
            TriviaQuestionAnswerOptions98.Add("The region in the sky where there is the highest chance of finding habitable planets.");
            TriviaQuestionAnswerOptions98.Add("The area around Earth inhabited by the Moon.");
            TriviaQuestion TriviaQuestionToAdd98 = new TriviaQuestion("What is the Goldilocks Zone?", TriviaQuestionAnswerOptions98, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd98);

            List<string> TriviaQuestionAnswerOptions99 = new List<string>();
            TriviaQuestionAnswerOptions99.Add("Valentina Tereshkova.");
            TriviaQuestionAnswerOptions99.Add("Sally Ride.");
            TriviaQuestionAnswerOptions99.Add("Katherine Johnson.");
            TriviaQuestionAnswerOptions99.Add("Nancy Grace Roman.");
            TriviaQuestion TriviaQuestionToAdd99 = new TriviaQuestion("Who was the first woman in space?", TriviaQuestionAnswerOptions99, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd99);

            List<string> TriviaQuestionAnswerOptions100 = new List<string>();
            TriviaQuestionAnswerOptions100.Add("1963.");
            TriviaQuestionAnswerOptions100.Add("2003.");
            TriviaQuestionAnswerOptions100.Add("1959.");
            TriviaQuestionAnswerOptions100.Add("1974.");
            TriviaQuestion TriviaQuestionToAdd100 = new TriviaQuestion("When did the first woman go to space?", TriviaQuestionAnswerOptions100, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd100);

            Utility.WriteTriviaToFile(ListofTriviaToWrite, Triviadatafiletouse);
        }
    }
}
