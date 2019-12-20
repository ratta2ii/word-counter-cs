# **Word Counter**

###### By Trevor Mackin 12/20/19  

### **Description**

_This is a console application built in C#. The program will gather both a word and a sentence from a user. It will then check how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)_


#
###  **Setup/Installation Requirements**

1. Open https://ratta2ii.github.io/word-counter-cs
2. Clone repository to local machine
3. $ dotnet build (run in the CLI in the WordCounter Directory)
4. $ dotnet run (run in the CLI to test with MSTest)
5. $ dotnet test (run in the CLI from the WordCounter.Tests Directory)

#
### **Specifications**

##### Example 1:
# 
####
_In this first example, I will choose a word that will only be used one time in the sentence, where the output counter will return a 1 for that single word._ 

####
    Please enter a single word.
    Input: dog
    Please enter a complete sentence. 
    Input: It truly does make sense that a dog has been called mans best friend.
    
    Output: 1
    
##### Example 2:
# 
####
_In this second example, I will choose a word that will be used multiple times throughout a sentenece, causing the application to return a number greater than 1._ 

####
    Please enter a single word.
    Input: beach
    Please enter a complete sentence. 
    Input: The beach has always been a part of my life, as I have been going to the beach since early childhood.
    
    Output: 2
    
##### Example 3:
# 
####
_In this example, I will choose a word that will be identical to a prefix of another word in the given sentence. This way we can make sure the application does not count that word, as we are only counting complete words._

####
    Please enter a single word.
    Input: photo
    Please enter a complete sentence. 
    Input: It has always been a dream of mine to get into photography.
    
    Output: 0
    
### **Technologies Used**

* C#
* netcoreapp2.2
* MSTest

### **License**

Copyright (c) 2019 **Trevor Mackin**