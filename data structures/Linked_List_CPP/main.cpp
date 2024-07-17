#include <iostream>

class Node{
    private:
        int data;
        Node* next;

    public:
        Node(){
            data = 0;
            next = NULL;
        }

        Node(int data){
            this->data = data;
            this->next = NULL;
        }

        Node get_Next();

        void set_Next(Node*);

        int get_Data();

        void set_Data(int);
};

Node Node::get_Next(){
    return *next;
}

void Node::set_Next(Node *newnode){
    this->next = newnode;
}

void Node::set_Data(int data){
    this->data = data;
}

int Node::get_Data(){
    return this->data;
}

class LinkedList{
    private:
        Node* head;

        Node GetLastNode();

    public:
        LinkedList(){
            head = NULL;
        }

        void push_Front(int);

        void push_Back(int);

        void printList();

        void pop_Index(int);
};

void LinkedList::push_Front(int data){
    Node* newNode = new Node(data);
    newNode->set_Next(head);
    head = newNode;
}

void LinkedList::push_Back(int data){
    Node* newNode = new Node(data);

    if(head == NULL){
        head = newNode;
        return;
    }


}

Node LinkedList::GetLastNode(){
    Node* temp = head;

    while(temp != NULL){
        *temp = temp->get_Next();
    }

    return *temp;
}

int main(){

    return 0;
}