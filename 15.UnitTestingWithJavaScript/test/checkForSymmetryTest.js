import { expect } from 'chai';
import { describe } from 'mocha';
import { isSymmetric } from '../checkForSymmetry.js';

describe('Is the array symmetric', () => {

    it('returns true for empty array', () => {
        expect(isSymmetric([])).to.be.true;
      });

    it('returns true for symmetric array', () => {
        expect(isSymmetric([1, 2, 3, 2, 1])).to.be.true;
        expect(isSymmetric(["a", "b", "a"])).to.be.true;
      });

    it('returns false for non-symmetric array', () => {
        expect(isSymmetric([1, 4, 3, 2, 3])).to.be.false;
        expect(isSymmetric(["c", "b", "a"])).to.be.false;
      });

      it('returns true for symmetric mixed input', () => {
        expect(isSymmetric([[1], 3, [1]])).to.be.true;
    });

    it('returns false for text input', () => {
        expect(isSymmetric('text')).to.be.false;
    });

    it('returns false for null input', () => {
        expect(isSymmetric(null)).to.be.false;
    });
});
