import { lookupChar } from '../charLookUp.js';
import { expect } from 'chai';

describe('Retrieve a character', () => {

    it('The first input is not correct', () => {

        expect(lookupChar(undefined, 2)).to.be.undefined;
        expect(lookupChar(4, 2)).to.be.undefined;
        expect(lookupChar(null, 2)).to.be.undefined;
        
    });
    
    it('The second input is not correct', () => {
        
        expect(lookupChar('text', '@')).to.be.undefined;
        expect(lookupChar('text', null)).to.be.undefined;
        expect(lookupChar('text', 'test')).to.be.undefined;
        expect(lookupChar('text', 2.5)).to.be.undefined;

    });

    it('The index is out of range', () => {

        let expected = 'Incorrect index';

        expect(lookupChar('text', -5)).to.equal(expected);
        expect(lookupChar('text', 5)).to.equal(expected);
        expect(lookupChar('text', 10)).to.equal(expected);

    });

    it('The input is correct', () => {

        expect(lookupChar('text', 0)).to.equal('t');
        expect(lookupChar('text', 3)).to.equal('t');
        expect(lookupChar('text', 2)).to.equal('x');

    });
  
});