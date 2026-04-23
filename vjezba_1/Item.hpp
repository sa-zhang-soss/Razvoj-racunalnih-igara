#ifndef ITEM_HPP
#define ITEM_HPP

class Character;

class Item {
public:
    virtual ~Item() {}
    virtual void use(Character& target) = 0;
};

#endif
