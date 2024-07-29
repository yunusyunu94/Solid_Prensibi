



#region İdeal Olmayan Code
//using static Liskov_Substitution_Princilbe.İdeal_Olmayan_Code;

//Clound clound = new AWS();

//clound.MachineLearning();
//clound.Translate();

//clound = new Google();

//clound.MachineLearning();
//clound.Translate();

//clound = new Azure();

//clound.MachineLearning();
//clound.Translate();         // Buradaki nesnede cikti vermeyecektir.

#endregion

#region İdeal Olmayan Code
using static Liskov_Substitution_Princilbe.Ornek1.İdeal_Code;

Clound clound = new AWS();
clound.MachineLearning();
(clound as ITranslatable)?.Translate();

clound = new Google();
clound.MachineLearning();
(clound as ITranslatable)?.Translate();

clound = new Azure();
clound.MachineLearning();
(clound as ITranslatable)?.Translate();

Clound dene = new AWS();
dene.MachineLearning();


#endregion

