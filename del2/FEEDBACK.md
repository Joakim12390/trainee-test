
Använd den här filen för att skriva din code review.

Du kommer att få möjlighet att presentera den även direkt till oss.

Feedback
Du kan använda en Arraylist istället. Den är mer flexibel och låser inte upp minne i onödan som t.ex om har 10 element i en array[1000], Då behöver man heller inte en stackpointer utan man använder istället arraylist.get(0) för att hämta översta elementet.

Din pop() metod tar inte bort elementet. Så det ligger kvar i arrayn. Det är ett problem om du kör contains() eller access() då den fortfarande kan hitta Object som inte finns längre.

Det är bra med korta variabelnamn men försök undvika 1 bokstavs variabelnamn, då det snabbt blir rörigt. (Ex Object o). Undantag är t.ex som counter i en for-loop.

contains() kan skrivas med en for-loop istället. Ex. for(int i = 0; i < stackpointer; i++) { if (item == data[i]) return true} return false; Blir fler men lite kortare rader, det är lite tydligare att läsa.

I access() returnera null istället för exception. Du kan skicka in ett giltigt object som inte finns i stacken just nu och då är det bättre att skicka null(elementet finns inte) istället för ett exception(något är fel).

stackPointer kan skrivas som pointer om du vill korta ner det lite, annars är det ok.

Väldokumenterad kod.
