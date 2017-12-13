package se.oneagency.trainee.part2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Joakim
 */

public class BasicStack implements Stack {

    // Stack data
    private List<Object> objects;
    
    public BasicStack() {
        objects = new ArrayList();
    }

    // Save element on top
    @Override
    public Stack push(Object newItem) {
        objects.add(newItem);
        return this;
    }

    // Delete and return top element
    @Override
    public Object pop() {
        Object obj = objects.get(0);
        objects.remove(0);
        return obj;
    }

    // Returns true is stack contains element, otherwise returns false
    @Override
    public boolean contains(Object item) {
        return objects.contains(item);
    }

    // pops all elements before item and pops item. Returns null if item isn't in the stack. Doesn't pop copies
    @Override
    public Object access(Object item) {
        Object obj = null;
        while(objects.size() > 0 && obj != item) {
            obj = pop();
        } 
        return obj;
    }

    // Returns true if stack is empty, otherwise returns false
    @Override
    public boolean isEmpty() {
        return objects.isEmpty();
    }   
}
