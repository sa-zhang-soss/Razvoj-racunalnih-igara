#ifndef INVENTORY_HPP
#define INVENTORY_HPP

#include <vector>

class Item;
class Character;

class Inventory {
    std::vector<Item*> items;
    size_t capacity;

public:
    Inventory(size_t cap);

    bool addItem(Item* item);
    void useItem(int index, Character& target);
};

#endif
