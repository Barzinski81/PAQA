import { expect } from 'chai';
import { describe } from 'mocha'
import { sum } from '../sumNumbers.js'; 

describe('Sum numbers', () => {
    it('sums single number', () => {
        expect(sum([3])).to.equal(3);
    });

    it('sums multiple numbers', () => {
        expect(sum([3,5])).to.equal(8);
    });

    it('sums different numbers', () => {
        expect(sum([3,5,8])).to.equal(16);
    });
});
