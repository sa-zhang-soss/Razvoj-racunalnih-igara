#include "Inventory.hpp"
#include "Item.hpp"
#include <iostream>

Inventory::Inventory(size_t cap) : capacity(cap) {}

bool Inventory::addItem(Item* item) {
    if (items.size() >= capacity) return false;
    items.push_back(item);
    return true;
}

void Inventory::useItem(int index, Character& target) {
    if (index < 0 || index >= (int)items.size()) return;

    items[index]->use(target);
    delete items[index];
    items.erase(items.begin() + index);
}