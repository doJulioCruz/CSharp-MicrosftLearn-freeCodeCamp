using System;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "Golden retriever feminino de cor creme de tamanho médio, pesando cerca de 29 quilos. domesticado.";
            animalPersonalityDescription = "adora ter a barriga esfregada e gosta de correr atrás do rabo. dá muitos beijos.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "grande golden retriever macho marrom-avermelhado pesando cerca de 38 quilos. domesticado.";
            animalPersonalityDescription = "adora que esfreguem as orelhas quando te cumprimenta na porta, ou a qualquer hora! adora se inclinar e dar abraços caninos.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "pequena fêmea branca pesando cerca de 3,6 quilos. sabe usar a caixa de areia.";
            animalPersonalityDescription = "amigável";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Espécie: " + animalSpecies;
    ourAnimals[i, 2] = "Idade: " + animalAge;
    ourAnimals[i, 3] = "Apelido: " + animalNickname;
    ourAnimals[i, 4] = "Descrição física: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personalidade: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Bem-vindo ao aplicativo Contoso PetFriends. As opções do menu principal são:");
    Console.WriteLine(" 1. Liste todas as informações atuais sobre nossos animais de estimação");
    Console.WriteLine(" 2. Adicione um novo amigo animal ao array ourAnimals");
    Console.WriteLine(" 3. Certifique-se de que as idades e descrições físicas dos animais estejam completas");
    Console.WriteLine(" 4. Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos");
    Console.WriteLine(" 5. Edite a idade de um animal");
    Console.WriteLine(" 6. Edite a descrição da personalidade de um animal");
    Console.WriteLine(" 7. Exibir todos os gatos com uma característica especificada");
    Console.WriteLine(" 8. Exibir todos os cães com uma característica especificada");
    Console.WriteLine();
    Console.WriteLine("Digite o número da sua seleção (ou digite SAIR para sair do programa)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            // Lista todas as nossas informações atuais sobre animais de estimação
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            readResult = Console.ReadLine();

            break;

        case "2":
            //Adiciona um novo amigo animal ao array ourAnimals
            string anotherPet = "s";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"Atualmente temos {petCount} animais precisando de um lar. Podemos cuidar de mais {(maxPets - petCount)} .");

            }

            while (anotherPet == "s" && petCount < maxPets)
            {
                bool validEntry = false;

                //identifica se a espécie é (gato ou cachorro) - a string animalSpecies é um campo obrigatório
                do
                {
                    Console.WriteLine("\n\r Digite 'cachorro' ou 'gato' para iniciar um novo cadastro ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();

                        if (animalSpecies != "cachorro" && animalSpecies != "gato")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    } while (validEntry == false);

                    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                    do
                    {
                        int petAge;
                        Console.WriteLine("Digite a idade do animal ou digite '?' caso não saiba.");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalAge = readResult;
                            if (animalAge != "?")
                            {
                                validEntry = int.TryParse(animalAge, out petAge);
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    //informa a descrição fisíca e condição aparente do animal - animalPhysicalDescription pode ficar em branco.
                    do
                    {
                        Console.WriteLine("Descreva o animal (tamanho, cor, sexo, peso, domesticado)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();

                            if (animalPhysicalDescription == "")
                            {
                                animalPhysicalDescription = "a ser definido";
                            }
                        }
                    } while (animalPersonalityDescription == "");

                    //descreve a personalidade do animal - animalPersonalityDescription pode ficar em branco.
                    do
                    {
                        Console.WriteLine("Descreva a personalidade do animal (manso ou não, carinhoso, brincalhão)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower();

                            if (animalPersonalityDescription == "")
                            {
                                animalPersonalityDescription = "a ser definido";
                            }
                        }
                    } while (animalPersonalityDescription == "");

                } while (validEntry == false);
                //incrementando petCount (o array é baseado em zero, então incrementamos um contador após adicionar ao array)
                petCount = petCount + 1;

                //checar o limite de maxPet
                if (petCount < maxPets)
                {
                    //Outro pet?
                    Console.WriteLine("Você gostaria de adicionar outro pet? (S/N)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }
                    } while (anotherPet != "s" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("Chegamos ao limite máximo de pets que podemos cuidar.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Certifique-se de que as idades e descrições físicas dos animais estejam completas
            Console.WriteLine("Projeto Desafio - volte em breve para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        case "4":
            // Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos
            Console.WriteLine("Projeto Desafio - volte em breve para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        case "5":
            // Edite a idade de um animal
            Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        case "6":
            // Edite a descrição da personalidade de um animal
            Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        case "7":
            // Exibir todos os gatos com uma característica especificada
            Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        case "8":
            //Exibir todos os cães com uma característica especificada
            Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar.");
            break;
        default:
            break;
    }
} while (menuSelection != "sair");