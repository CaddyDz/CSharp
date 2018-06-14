using System.Collections;
using System.Collections.Generic;

namespace CSharpTutA
{
		class AnimalFarm : IEnumerable
		{
				private List<Animal> animalList = new List<Animal>();

				public AnimalFarm(List<Animal> animalList)
				{
						this.animalList = animalList;
				}

				public AnimalFarm()
				{
						
				}

				public Animal this[int index]
				{
					get
					{
						return (Animal) animalList[index];
					}
					set
					{
						animalList.Insert(index, value);
					}
				}

				public int Count
				{
					get {return animalList.Count;}
				}

				IEnumerator IEnumerable.GetEnumerator()
				{
					return animalList.GetEnumerator();
				}
		}
}