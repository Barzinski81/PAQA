import { mathEnforcer } from '../mathEnforcer.js'
import { expect } from 'chai'

describe('Math enforcer', () => {

    it('Test add 5', () => {

        expect(mathEnforcer.addFive('a')).to.be.undefined;
        expect(mathEnforcer.addFive([1, 2, 3])).to.be.undefined;
        expect(mathEnforcer.addFive(null)).to.be.undefined;
        expect(mathEnforcer.addFive(undefined)).to.be.undefined;

        expect(mathEnforcer.addFive(5)).to.equal(10);
        expect(mathEnforcer.addFive(-5)).to.equal(0);
        expect(mathEnforcer.addFive(0)).to.equal(5);
        expect(mathEnforcer.addFive(-15.5)).to.be.closeTo(-10.5, 0.01);
    });

    it('Test subtract 10', () => {

        expect(mathEnforcer.subtractTen('a')).to.be.undefined;
        expect(mathEnforcer.subtractTen([1, 2, 3])).to.be.undefined;
        expect(mathEnforcer.subtractTen(null)).to.be.undefined;
        expect(mathEnforcer.subtractTen(undefined)).to.be.undefined;

        expect(mathEnforcer.subtractTen(50)).to.equal(40);
        expect(mathEnforcer.subtractTen(-5)).to.equal(-15);
        expect(mathEnforcer.subtractTen(0)).to.equal(-10);
        expect(mathEnforcer.subtractTen(-15.5)).to.be.closeTo(-25.5, 0.01);
        
    });

    it('Test sum two numbers', () => {

        expect(mathEnforcer.sum('a', 3)).to.be.undefined;
        expect(mathEnforcer.sum([1, 2, 3], 3)).to.be.undefined;
        expect(mathEnforcer.sum(null, 3)).to.be.undefined;
        expect(mathEnforcer.sum(undefined, 3)).to.be.undefined;

        expect(mathEnforcer.sum(5, 'b')).to.be.undefined;
        expect(mathEnforcer.sum(5, [1, 2, 3])).to.be.undefined;
        expect(mathEnforcer.sum(5, null)).to.be.undefined;
        expect(mathEnforcer.sum(5, undefined)).to.be.undefined;

        expect(mathEnforcer.sum(5, 3)).to.equal(8);
        expect(mathEnforcer.sum(-5, 3)).to.equal(-2);
        expect(mathEnforcer.sum(-5, -3)).to.equal(-8);
        expect(mathEnforcer.sum(5, 0)).to.equal(5);
        expect(mathEnforcer.sum(0, -3)).to.equal(-3);
        expect(mathEnforcer.sum(5.5, 3.2)).to.be.closeTo(8.7, 0.01);
        
    });

});     