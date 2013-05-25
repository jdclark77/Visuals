ko.bindingHandlers.clickoutside = {
	init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
		$(element).bind('clickoutside', function () {
			if ((valueAccessor())()) {
				(valueAccessor())(false);
			}
		});
	},
	update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
	}
};
ko.bindingHandlers.disableLink = {
	init: function (element, valueAccessor, allBindingsAccessor, context) {
		var value = valueAccessor();
		if (value) {
			$(element).removeAttr('href');
			return;
		}
		$(element).attr('href', "#");

	},
	update: function (element, valueAccessor, allBindingsAccessor, context) {
		var value = valueAccessor();
		if (value) {
			$(element).removeAttr('href');
			return;
		}
		$(element).attr('href', "#");

	}
};

ko.bindingHandlers.executeOnEnterAndLoseFocus = {
	init: function (element, valueAccessor, allBindingsAccessor, viewModel) {
		var allBindings = allBindingsAccessor();
		$(element).keypress(function (event) {
			var keyCode = (event.which ? event.which : event.keyCode);
			if (keyCode === 13) {
				allBindings.executeOnEnter.call(viewModel);
				return false;
			}
			return true;
		});
	}
};
